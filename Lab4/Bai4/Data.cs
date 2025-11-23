    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Drawing;

namespace Bai4
{
        internal class Data
        {
            public static Dictionary<string, FilmInfo> filmData = new Dictionary<string, FilmInfo>();

            public static List<(string Film, string Theater, string Seat)> choosingSeat
                = new List<(string, string, string)>();

            public static Dictionary<string, Dictionary<string, HashSet<string>>> bookedSeats
                = new Dictionary<string, Dictionary<string, HashSet<string>>>();

        public static async Task LoadFilmData()
        {
            var url = "https://betacinemas.vn/phim.htm";

            using (HttpClient client = new HttpClient())
            {
                // Thêm User-Agent để tránh bị chặn
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

                var html = await client.GetStringAsync(url);
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                var movieCards = doc.DocumentNode.SelectNodes("//div[contains(@class,'film-info')]");
                if (movieCards == null) return;

                foreach (var card in movieCards)
                {
                    // 1. Tên phim và URL chi tiết
                    var titleNode = card.SelectSingleNode(".//h3/a");
                    if (titleNode == null) continue;

                    string filmName = titleNode.InnerText.Trim();
                    string detailHref = titleNode.GetAttributeValue("href", "").Trim();
                    string detailUrl = new Uri(new Uri(url), detailHref).ToString();

                    string posterUrl = "";
                    var parentRowNode = card.ParentNode?.ParentNode;

                    if (parentRowNode != null)
                    {
                        var imgNode = parentRowNode.SelectSingleNode(".//img[contains(@class,'border-radius-20')]");

                        if (imgNode != null)
                        {
                            posterUrl = imgNode.GetAttributeValue("src", "").Trim();
                        }
                    }

                    if (!string.IsNullOrEmpty(posterUrl))
                    {
                        if (Uri.TryCreate(new Uri(url), posterUrl, out Uri abs))
                            posterUrl = abs.ToString();
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine($"Không tìm thấy Poster URL cho phim: {filmName}");
                    }

                    if (!filmData.ContainsKey(filmName))
                    {
                        filmData[filmName] = new FilmInfo
                        {
                            Name = filmName,
                            DetailUrl = detailUrl,
                            PosterUrl = posterUrl,
                            BasePrice = 75000,
                            Theaters = new List<string> { "1", "2", "3" }
                        };
                    }
                }
            }
        }


        public static Dictionary<string, FilmInfo> GetData()
        {
            return filmData;
        }

        public static void BookSeat(string movie, string theater, string seat)
        {
            if (!bookedSeats.ContainsKey(movie))
                bookedSeats[movie] = new Dictionary<string, HashSet<string>>();
            if (!bookedSeats[movie].ContainsKey(theater))
                bookedSeats[movie][theater] = new HashSet<string>();
            bookedSeats[movie][theater].Add(seat);
        }

        public class FilmInfo
        {
            public string Name { get; set; }
            public decimal BasePrice { get; set; }
            public List<string> Theaters { get; set; }
            public int TotalSeats { get; } = 15;
            public string PosterUrl { get; set; }
            public string Title { get; set; }
            public string DetailUrl { get; set; }
        }
        public static string GetTypeSeat(string seat)
        {
            if (seat == "A1" || seat == "A5" || seat == "C1" || seat == "C5")
                return "Vớt";
            else if (seat == "A2" || seat == "A3" || seat == "A4" ||
                     seat == "C2" || seat == "C3" || seat == "C4")
                return "Thường";
            else
                return "VIP"; // Bao gồm B1, B2, B3, B4, B5
        }

        // Hàm tính giá ghế
        public static decimal CalculatePrice(decimal basePrice, string seat)
        {
            string loai = GetTypeSeat(seat);
            if (loai == "Vớt") return basePrice * 0.25m;
            if (loai == "Thường") return basePrice;
            return basePrice * 2m;
        }
    }

}
