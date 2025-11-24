
using HtmlAgilityPack;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;


namespace Bai3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();

        }


        private void WebView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            if (webView21.CoreWebView2 != null)
            {
                txtUrl.Text = webView21.Source.ToString(); // Hiển thị URL

            }
        }



        private async void Load_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            if (!string.IsNullOrEmpty(url))
            {
                webView21.Source = new Uri(url);
            }
        }

        private async void DownFiles_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            if (!string.IsNullOrEmpty(url))
            {
                string html = await GetHtmlAsync(url);
                File.WriteAllText("downloaded.html", html);
                MessageBox.Show("HTML downloaded successfully!");
            }
        }



        private async void DownResources_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            if (!string.IsNullOrEmpty(url))
            {
                string html = await GetHtmlAsync(url);
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                // 1. Lưu mã nguồn HTML
                string htmlFilePath = Path.Combine("downloaded.html");
                await File.WriteAllTextAsync(htmlFilePath, html);

                // 2. Lưu toàn bộ văn bản (text) của trang web
                string allText = doc.DocumentNode.InnerText;
                string textFilePath = Path.Combine("downloaded_text.txt");
                await File.WriteAllTextAsync(textFilePath, allText);

                // 3. Tải tất cả ảnh về thư mục Images
                var imgNodes = doc.DocumentNode.SelectNodes("//img[@src]");
                if (imgNodes != null)
                {
                    using HttpClient client = new HttpClient();
                    Directory.CreateDirectory("Images");


                    foreach (var img in imgNodes)
                    {
                        string imgUrl = img.GetAttributeValue("src", "");
                        if (!imgUrl.StartsWith("http"))
                            imgUrl = new Uri(new Uri(url), imgUrl).ToString();

                        // Tạo tên file an toàn
                        string safeFileName = Path.GetFileName(imgUrl);

                        // Nếu tên file rỗng hoặc chứa ký tự đặc biệt, dùng GUID
                        if (string.IsNullOrEmpty(safeFileName) || safeFileName.Contains("?") || safeFileName.Contains("&"))
                        {
                            safeFileName = Guid.NewGuid().ToString() + ".jpg"; // hoặc .png
                        }

                        string fileName = Path.Combine("Images", safeFileName);
                        byte[] imgData = await client.GetByteArrayAsync(imgUrl);
                        await File.WriteAllBytesAsync(fileName, imgData);
                    }

                }

                MessageBox.Show("HTML, text, and images downloaded successfully!");
            }
        }


        private void Reload_Click(object sender, EventArgs e)
        {
            webView21.Reload();
        }

        private async Task<string> GetHtmlAsync(string url)
        {
            using HttpClient client = new HttpClient();
            return await client.GetStringAsync(url);
        }
    }
}
