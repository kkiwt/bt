using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace Bai7
{
    public partial class ThemMonAn : Form
    {
        private TokenInfo tokenInfo;
        private string username;
        public ThemMonAn()
        {
            InitializeComponent();
        }
        public ThemMonAn(TokenInfo tokenInfo, string username)
        {
            InitializeComponent();
            this.tokenInfo = tokenInfo;
            this.username = username;
        }

        private void NutClear_Click(object sender, EventArgs e)
        {
            TenMonAnText.Clear();
            GiaText.Clear();
            MoTaText.Clear();
            HinhAnhText.Clear();
            DiaChiText.Clear();
        }




        private async void NutThemMon_Click(object sender, EventArgs e)
        {
            string tenMon = TenMonAnText.Text.Trim();
            string giaStr = GiaText.Text.Trim();
            string moTa = MoTaText.Text.Trim();
            string hinhAnh = HinhAnhText.Text.Trim();
            string diaChi = DiaChiText.Text.Trim();

            if (string.IsNullOrEmpty(tenMon) || string.IsNullOrEmpty(giaStr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!decimal.TryParse(giaStr, out decimal gia))
            {
                MessageBox.Show("Giá phải là số!");
                return;
            }

            var url = "https://nt106.uitiot.vn/api/v1/monan/add";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue(tokenInfo.TokenType, tokenInfo.AccessToken);

                var data = new
                {
                    ten_mon_an = tenMon,
                    gia = gia,
                    mo_ta = moTa,
                    hinh_anh = hinhAnh,
                    dia_chi = diaChi
                };

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(url, content);
                var result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm món ăn thành công!");

                    var parentForm = this.Owner as TrangChu;
                    if (parentForm != null)
                    {
                        await parentForm.LoadMonAnAsync(true); // Reload tab "Tôi Đóng Góp"
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Lỗi: {result}");
                }
            }
        }





        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
