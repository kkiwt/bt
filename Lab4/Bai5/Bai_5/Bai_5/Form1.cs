using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Bai_5
{
    public partial class Bai_5 : Form
    {
        public string TokenType = "";
        public string AccessToken = "";

        public Bai_5()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string user = textBoxUsername.Text.Trim();
            string pass = textBoxPassword.Text.Trim();

            if (user == "" || pass == "")
            {
                MessageBox.Show("Vui lòng nhập username và password!");
                return;
            }

            string url = textBoxURL.Text.Trim();

            using (var client = new HttpClient())
            {
                var content = new MultipartFormDataContent
                {
                    { new StringContent(user), "username" },
                    { new StringContent(pass), "password" }
                };

                var response = await client.PostAsync(url, content);
                string json = await response.Content.ReadAsStringAsync();

                var obj = JObject.Parse(json);

                rtbResult.Clear();

                if (!response.IsSuccessStatusCode)
                {
                    rtbResult.Text = "Đăng nhập thất bại!\n"
                                      + obj["detail"]?.ToString();
                    return;
                }

                TokenType = obj["token_type"].ToString();
                AccessToken = obj["access_token"].ToString();

                rtbResult.Text =
                    "Đăng nhập thành công!\n\n" +
                    $"token_type = {TokenType}\n" +
                    $"access_token = {AccessToken}";
            }
        }
    }
}
