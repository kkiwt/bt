using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using System.Runtime.InteropServices;

namespace Bai7
{
    public partial class DangKy : Form
    {
        private readonly string BaseUrl = "https://nt106.uitiot.vn/";
        private readonly HttpClient client;
        public DangKy()
        {
            InitializeComponent();
        }
        public async Task<string> SignupAsync(object userData)
        {
            var json = JsonSerializer.Serialize(userData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(BaseUrl + "api/v1/user/signup", content);
            return await response.Content.ReadAsStringAsync();
        }





        private async void NutDangKy_Click(object sender, EventArgs e)
        {
            string username = TenTaiKhoanText.Text.Trim();
            string password = MatKhauText.Text.Trim();
            string email = EmailText.Text.Trim();
            string firstName = FirstNameText.Text.Trim();
            string lastName = LastNameText.Text.Trim();
            string phone = PhoneText.Text.Trim();
            string language = LanguageCombo.SelectedItem?.ToString();

            int sex = Male.Checked ? 0 : (Female.Checked ? 1 : -1);
            string birthday = BirthdayDate.Value.ToString("yyyy-MM-dd");

            // Validate cơ bản
            if (string.IsNullOrEmpty(username) || username.Length < 4)
            {
                MessageBox.Show("Tên tài khoản phải có ít nhất 4 ký tự!");
                return;
            }

            if (string.IsNullOrEmpty(password) || password.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!");
                return;
            }

            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }

            if (sex == -1)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return;
            }

            if (BirthdayDate.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return;
            }

            if (string.IsNullOrEmpty(language))
            {
                MessageBox.Show("Vui lòng chọn ngôn ngữ!");
                return;
            }

            if (!string.IsNullOrEmpty(phone) && !phone.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa số!");
                return;
            }

            var userData = new
            {
                username = username,
                email = email,
                password = password,
                first_name = firstName,
                last_name = lastName,
                sex = sex,
                birthday = birthday,
                language = language,
                phone = phone
            };

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var json = JsonSerializer.Serialize(userData);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/user/signup", content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Đăng ký thành công!");
                        DangNhap DN = new DangNhap();
                        DN.Show();
                        this.Close(); // Quay về form đăng nhập


                    }
                    else
                    {
                        MessageBox.Show("Lỗi: " + responseString);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }




        private void NutClear_Click(object sender, EventArgs e)
        {
            // Clear TextBoxes
            TenTaiKhoanText.Clear();
            MatKhauText.Clear();
            EmailText.Clear();
            FirstNameText.Clear();
            LastNameText.Clear();
            PhoneText.Clear();

            // Reset ComboBox
            LanguageCombo.SelectedIndex = -1;

            // Reset RadioButtons
            Male.Checked = false;
            Female.Checked = false;

            // Reset DateTimePicker
            BirthdayDate.Value = DateTime.Now;
        }


        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            Female.Checked = false;
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            Male.Checked = false;
        }
    }

}
