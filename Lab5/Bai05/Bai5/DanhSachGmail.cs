using HtmlAgilityPack;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using Supabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai7
{
    public partial class DanhSachGmail : Form
    {
        private bool _loadedOnce = false;
        private readonly HashSet<string> _seenKeys = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        private class GmailMonDto
        {
            public string Ten { get; set; }
            public int Gia { get; set; }
            public string DiaChi { get; set; }
            public string NguoiDongGop { get; set; }
            public string HinhAnhUrl { get; set; }
        }

        public DanhSachGmail()
        {
            InitializeComponent();

        }

        private async void DanhSachGmail_Load(object? sender, EventArgs e)
        {
            DanhSachMonAn.View = View.Details;
            DanhSachMonAn.FullRowSelect = true;
            DanhSachMonAn.MultiSelect = true;

            DanhSachMonAn.Columns.Clear();
            DanhSachMonAn.Columns.Add("Tên món", 250);
            DanhSachMonAn.Columns.Add("Giá", 100);
            DanhSachMonAn.Columns.Add("Địa chỉ", 250);
            DanhSachMonAn.Columns.Add("Người đóng góp", 180);
            DanhSachMonAn.Columns.Add("Hình ảnh (URL)", 300);

            if (!_loadedOnce)
                await LoadFromGmailAsync();
        }


        private string ExtractTextFromHtml(string html)
        {
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            string text = HtmlEntity.DeEntitize(doc.DocumentNode.InnerText);

            return text
                .Replace("\u00A0", " ")
                .Replace("\u200B", "")
                .Replace("\uFEFF", "")
                .Normalize(NormalizationForm.FormC)
                .Trim();
        }




        private GmailMonDto ParseLineFixed(string rawLine, string fallbackContributor)
        {
            if (string.IsNullOrWhiteSpace(rawLine)) return null;

            string line = rawLine
                .Replace("\r", "")
                .Replace("\n", " ")
                .Replace("\u00A0", " ")
                .Replace("\u200B", "")
                .Normalize(NormalizationForm.FormC)
                .Trim();


            var parts = line.Split(';').Select(p => p.Trim()).Where(p => p.Length > 0).ToList();

            // Chỉ chấp nhận 4 hoặc 5 trường
            if (parts.Count != 4 && parts.Count != 5) return null;

            string ten = parts[0];
            string url = parts[1];
            string giaRaw = parts[2];
            string diaChi = parts[3];

            string nguoi = (parts.Count == 5 && !string.IsNullOrWhiteSpace(parts[4]))
                ? parts[4]
                : (string.IsNullOrWhiteSpace(fallbackContributor) ? "Người ẩn danh" : fallbackContributor);

            int gia = 0;
            int.TryParse(Regex.Replace(giaRaw, @"[^\d]", ""), out gia);

            return new GmailMonDto
            {
                Ten = ten,
                HinhAnhUrl = url,
                DiaChi = diaChi,
                Gia = gia,
                NguoiDongGop = nguoi
            };
        }





        private static List<string> SplitSemicolonCsv(string line)
        {
            var result = new List<string>();
            var sb = new StringBuilder();
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (c == '"')
                {

                    if (inQuotes && i + 1 < line.Length && line[i + 1] == '"')
                    {
                        sb.Append('"');
                        i++; 
                    }
                    else
                    {
                        inQuotes = !inQuotes;
                    }
                }
                else if (c == ';' && !inQuotes)
                {
                    result.Add(sb.ToString().Trim());
                    sb.Clear();
                }
                else
                {
                    sb.Append(c);
                }
            }

            result.Add(sb.ToString().Trim());
            return result;
        }




        private async Task LoadFromGmailAsync()
        {
            if (_loadedOnce) return;

            try
            {

                progressBar.Visible = true;
                progressBar.Style = ProgressBarStyle.Marquee;
                progressBar.MarqueeAnimationSpeed = 40;

                string gmail = Environment.GetEnvironmentVariable("GMAIL_ADDRESS") ?? "nkiet0651@gmail.com";
                string pass = Environment.GetEnvironmentVariable("GMAIL_APP_PASSWORD") ?? "obpjapgduwetufgp";

                using var imap = new ImapClient();
                await imap.ConnectAsync("imap.gmail.com", 993, true);
                await imap.AuthenticateAsync(gmail, pass);

                var inbox = imap.Inbox;
                await inbox.OpenAsync(FolderAccess.ReadWrite);

                var uids = await inbox.SearchAsync(SearchQuery.SubjectContains("Đóng góp món ăn"));

                DanhSachMonAn.BeginUpdate();
                DanhSachMonAn.Items.Clear();
                _seenKeys.Clear();

                foreach (var uid in uids)
                {
                    var msg = await inbox.GetMessageAsync(uid);
                    string contributor = "Người ẩn danh";

                    string body = msg.TextBody;
                    if (string.IsNullOrWhiteSpace(body) && !string.IsNullOrWhiteSpace(msg.HtmlBody))
                        body = ExtractTextFromHtml(msg.HtmlBody);

                    if (body == null) continue;

                    string[] lines = body.Replace("\r", "").Split('\n');
                    string buffer = "";

                    foreach (var raw in lines)
                    {
                        string line = raw.Trim();
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        buffer = string.IsNullOrEmpty(buffer) ? line : (buffer + " " + line);

                        var dto = ParseLineFixed(buffer, contributor);
                        if (dto != null)
                        {
                            buffer = "";
                            string key = $"{dto.Ten}\n{dto.HinhAnhUrl}\n{dto.Gia}\n{dto.DiaChi}";
                            if (!_seenKeys.Add(key)) continue;

                            var item = new ListViewItem(new[]
                            {
                        dto.Ten,
                        dto.Gia.ToString(),
                        dto.DiaChi,
                        dto.NguoiDongGop,
                        dto.HinhAnhUrl
                    });
                            item.Tag = dto;
                            DanhSachMonAn.Items.Add(item);
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(buffer))
                    {
                        var dto = ParseLineFixed(buffer, contributor);
                        if (dto != null)
                        {
                            string key = $"{dto.Ten}\n{dto.HinhAnhUrl}\n{dto.Gia}\n{dto.DiaChi}";
                            if (_seenKeys.Add(key))
                            {
                                var item = new ListViewItem(new[]
                                {
                            dto.Ten,
                            dto.Gia.ToString(),
                            dto.DiaChi,
                            dto.NguoiDongGop,
                            dto.HinhAnhUrl
                        });
                                item.Tag = dto;
                                DanhSachMonAn.Items.Add(item);
                            }
                        }
                    }
                }

                DanhSachMonAn.EndUpdate();
                _loadedOnce = true;
                await imap.DisconnectAsync(true);
            }
            catch (Exception ex)
            {
                DanhSachMonAn.EndUpdate();
                MessageBox.Show("Lỗi load Gmail: " + ex.Message);
            }
            finally
            {

                progressBar.Visible = false;
                progressBar.Style = ProgressBarStyle.Blocks;
            }
        }


        private void NutQuayLai_Click(object? sender, EventArgs e)
        {
            this.Close();
        }





        private bool _isUploading = false;

        private async void NutTai_Click(object? sender, EventArgs e)
        {
            if (_isUploading) return;
            _isUploading = true;

            try
            {
                await SupabaseHolder.InitializeAsync();
                var client = SupabaseHolder.Client;

                if (DanhSachMonAn.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Hãy chọn ít nhất 1 dòng.");
                    return;
                }

                // ✅ Khoá UI & hiển thị progress determinate
                NutTai.Enabled = false;
                progressBar.Visible = true;
                progressBar.Style = ProgressBarStyle.Blocks;
                progressBar.Minimum = 0;
                progressBar.Maximum = DanhSachMonAn.SelectedItems.Count;
                progressBar.Value = 0;

                int inserted = 0, skipped = 0, processed = 0;

                foreach (ListViewItem it in DanhSachMonAn.SelectedItems)
                {
                    if (it.Tag is not GmailMonDto dto)
                    {
                        skipped++;
                        processed++;
                        progressBar.Value = processed; // tăng tiến độ
                        continue;
                    }

                    // Kiểm tra trùng tên + ảnh
                    var exists = await client
                        .From<MonAnModel>()
                        .Filter("ten_mon_an", Supabase.Postgrest.Constants.Operator.Equals, dto.Ten)
                        .Filter("hinh_anh", Supabase.Postgrest.Constants.Operator.Equals, dto.HinhAnhUrl)
                        .Get();

                    if (exists.Models.Count > 0)
                    {
                        skipped++;
                    }
                    else
                    {
                        var rpcParams = new Dictionary<string, object>
                        {
                            ["p_ten_mon_an"] = dto.Ten,
                            ["p_gia"] = dto.Gia,
                            ["p_mo_ta"] = "Đóng góp qua Gmail",
                            ["p_hinh_anh"] = dto.HinhAnhUrl,
                            ["p_dia_chi"] = dto.DiaChi,
                            ["p_nguoi_dong_gop"] = dto.NguoiDongGop
                        };

                        var rpcResp = await client.Postgrest.Rpc<string>("insert_monan", rpcParams);
                        if (!string.IsNullOrEmpty(rpcResp))
                        {
                            inserted++;
                            it.ForeColor = System.Drawing.Color.Gray; // đánh dấu đã upload
                        }
                        else
                        {
                            skipped++;
                        }
                    }

                    processed++;
                    progressBar.Value = processed; 
                }

                MessageBox.Show($"Thêm {inserted}, bỏ qua {skipped}");

      
                try
                {
                    if (inserted > 0 && this.Owner is TrangChu parent)
                    {
                        parent.tabControl2.SelectedTab = parent.GmailTabPage;
                        await parent.LoadMonAnGmailAsync();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi reload TrangChu: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {

                progressBar.Visible = false;
                progressBar.Style = ProgressBarStyle.Blocks;

                NutTai.Enabled = true;
                _isUploading = false;
            }
        }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}

