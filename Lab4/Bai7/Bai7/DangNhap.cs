using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
namespace Bai7
{



    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();

        }

        private async void NutDangNhap_Click(object sender, EventArgs e)
        {
            string username = TaiKhoanText.Text.Trim();
            string password = MatKhauText.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var content = new MultipartFormDataContent
            {
                { new StringContent(username), "username" },
                { new StringContent(password), "password" }
            };

                    var response = await client.PostAsync("https://nt106.uitiot.vn/auth/token", content);
                    var responseString = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(responseString);

                    if (!response.IsSuccessStatusCode)
                    {
                        string detail = json["detail"]?.ToString() ?? "Đăng nhập thất bại!";
                        MessageBox.Show(detail);
                        return;
                    }

                    string tokenType = json["token_type"].ToString();
                    string accessToken = json["access_token"].ToString();
                    string refreshToken = json["refresh_token"]?.ToString(); // nếu API trả về

                    MessageBox.Show("Đăng nhập thành công!");

                    // Lưu token vào class
                    TokenInfo tokenInfo = new TokenInfo
                    {
                        TokenType = tokenType,
                        AccessToken = accessToken,
                        RefreshToken = refreshToken
                    };
                    MessageBox.Show("Đăng Nhập Thàn Công");
                    // Mở form chính và truyền tokenInfo
                    TrangChu mainForm = new TrangChu(tokenInfo, username);
                    mainForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }



        public async Task<string> RefreshTokenAsync(string refreshToken)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = new { refresh = refreshToken };
                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://nt106.uitiot.vn/auth/refresh", content);
                return await response.Content.ReadAsStringAsync();
            }
        }


        private void DangKyLabel_Click(object sender, EventArgs e)
        {
           DangKy dkForm = new DangKy();
           dkForm.Show();
           this.Hide();

        }
    }
    public class TokenInfo
    {
        public string TokenType { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}




