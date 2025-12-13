
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit;
using MimeKit;
using Supabase;

namespace Bai7
{
    public class GmailContributionService
    {
        private readonly string _gmailAddress;
        private readonly string _appPassword;
        private readonly Client _supabaseClient;

        public GmailContributionService(string gmailAddress, string appPassword, Client supabaseClient)
        {
            _gmailAddress = gmailAddress;
            _appPassword = appPassword;
            _supabaseClient = supabaseClient;
        }

        private static bool LooksLikeUrl(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false;
            return Uri.IsWellFormedUriString(s, UriKind.Absolute)
                   || Regex.IsMatch(s, @"\.(jpg|jpeg|png|gif|webp)$", RegexOptions.IgnoreCase);
        }

        private static bool LooksLikePrice(string s, out int price)
        {
            price = 0;
            if (string.IsNullOrWhiteSpace(s)) return false;
            var digits = Regex.Replace(s, @"[^\d]", "");
            return int.TryParse(digits, out price);
        }

        private static bool LooksLikeAddress(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false;
            if (LooksLikeUrl(s)) return false;

            var onlyDigits = Regex.Replace(s, @"[^\d]", "");
            if (!string.IsNullOrEmpty(onlyDigits) && onlyDigits.Length == s.Length) return false;

            var lower = s.ToLowerInvariant();
            string[] hints = { "đường", "phố", "quận", "q.", "phường", "p.", "tp", "thủ đức", "hồ chí minh", "," };
            return hints.Any(h => lower.Contains(h)) || s.Contains(' ');
        }

        private static (string Ten, int Gia, string DiaChi, string Url) ParseLineSmart(string line)
        {
            var parts = line.Split(';', StringSplitOptions.RemoveEmptyEntries)
                            .Select(p => p.Trim()).ToArray();
            if (parts.Length < 2) return default;

            string ten = null, url = null, diaChi = null;
            int gia = 0; bool giaSet = false;

            foreach (var p in parts)
            {
                if (url == null && LooksLikeUrl(p)) { url = p; continue; }
                if (!giaSet && LooksLikePrice(p, out var g)) { gia = g; giaSet = true; continue; }
                if (diaChi == null && LooksLikeAddress(p)) { diaChi = p; continue; }
                if (ten == null) ten = p;
            }

            if (string.IsNullOrWhiteSpace(ten)) ten = "(chưa đặt tên)";
            return (ten, gia, diaChi ?? "", url ?? "");
        }


        public async Task<List<MonAnModel>> DownloadAndStoreAndReturnAsync()
        {
            var insertedModels = new List<MonAnModel>();
            try
            {
                using var imap = new ImapClient();
                await imap.ConnectAsync("imap.gmail.com", 993, true);
                await imap.AuthenticateAsync(_gmailAddress, _appPassword);

                var inbox = imap.Inbox;
                await inbox.OpenAsync(FolderAccess.ReadWrite);


                var query = SearchQuery.SubjectContains("Đóng góp món ăn").And(SearchQuery.NotSeen);
                var uids = await inbox.SearchAsync(query);

                foreach (var uid in uids)
                {
                    var msg = await inbox.GetMessageAsync(uid);
                    string contributor = msg.From?.Mailboxes?.FirstOrDefault()?.Name ?? "Người ẩn danh";

     
                    string body = msg.TextBody;
                    if (string.IsNullOrWhiteSpace(body) && !string.IsNullOrWhiteSpace(msg.HtmlBody))
                        body = Regex.Replace(msg.HtmlBody, "<.*?>", string.Empty);

                    if (string.IsNullOrWhiteSpace(body))
                    {
                        await inbox.AddFlagsAsync(uid, MessageFlags.Seen, true);
                        continue;
                    }

                    var lines = body.Replace("\r", "").Split('\n', StringSplitOptions.RemoveEmptyEntries);

                    foreach (var line in lines)
                    {
                        var parsed = ParseLineSmart(line);
                        if (parsed.Equals(default((string, int, string, string)))) continue;

                        var ten = parsed.Ten;
                        var url = parsed.Url;
                        var gia = parsed.Gia;
                        var diaChi = parsed.DiaChi;


                        var existsResp = await _supabaseClient
                            .From<MonAnModel>()
                            .Filter("ten_mon_an", Supabase.Postgrest.Constants.Operator.Equals, ten)
                            .Filter("hinh_anh", Supabase.Postgrest.Constants.Operator.Equals, url)
                            .Get();

                        if (existsResp.Models?.Count > 0) continue;

                        var item = new MonAnModel
                        {
                            TenMonAn = ten,
                            Gia = gia,
                            MoTa = "Đóng góp qua Gmail",
                            HinhAnh = url,
                            DiaChi = diaChi,
                            NguoiDongGop = contributor
                        };

                        try
                        {

                        }
                        catch
                        {
      
                            continue;
                        }
                    }

                    // Đánh dấu mail đã xử lý
                    await inbox.AddFlagsAsync(uid, MessageFlags.Seen, true);
                }

                await imap.DisconnectAsync(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải Gmail: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return insertedModels;
        }
    }
}
