using Newtonsoft.Json;
using System;
using System.Buffers.Text;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.VisualBasic.Logging;



namespace Bai7
{
    
    public partial class TrangChu : Form
    {
        private TokenInfo tokenInfo;
        private string username;
        private List<dynamic> allMonAnList = new List<dynamic>();

        public TrangChu(TokenInfo tokenInfo, string username)
        {
            InitializeComponent();
            this.tokenInfo = tokenInfo;
            this.username = username;
            WelcomeText.Text = $"Welcome, {username}";
        }


        private async void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }




        private async void TrangChu_Load(object sender, EventArgs e)
        {

            PageCombo.Items.AddRange(new string[] { "1", "2", "3", "4", "5" });
            PageSizeCombo.Items.AddRange(new string[] { "5", "10", "15", "20", "100" });

            PageCombo.SelectedIndex = 0;
            PageSizeCombo.SelectedIndex = 0;

            await LoadMonAnAsync(false); // Load All
            await LoadMonAnAsync(true);  // Load Tôi Đóng Góp

        }



        private void NutThemMonAn_Click(object sender, EventArgs e)
        {
            ThemMonAn ThemMon = new ThemMonAn(tokenInfo, username);
            ThemMon.Owner = this; // Quan trọng để gọi LoadMonAnAsync
            ThemMon.Show();
        }

        private async void AllTabPage_Click(object sender, EventArgs e)
        {
            await LoadMonAnAsync(false);
        }

        private async void ToiDongGopTabPage_Click(object sender, EventArgs e)
        {
            await LoadMonAnAsync(true);

        }

        private void NutLogOut_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Close();
        }






        public async Task DeleteMonAnAsync(int id)
        {
            var url = $"https://nt106.uitiot.vn/api/v1/monan/{id}";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue(tokenInfo.TokenType, tokenInfo.AccessToken);

                var response = await client.DeleteAsync(url);
                var result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Xóa món ăn thành công!");
                    await LoadMonAnAsync(true);  // Reload Tôi Đóng Góp
                }
                else
                {
                    MessageBox.Show($"Lỗi khi xóa: {result}");
                }
            }
        }




        public async Task LoadMonAnAsync(bool isMyDishes = false)
        {
            int currentPage = PageCombo.SelectedItem != null ? int.Parse(PageCombo.SelectedItem.ToString()) : 1;
            int pageSize = PageSizeCombo.SelectedItem != null ? int.Parse(PageSizeCombo.SelectedItem.ToString()) : 5;

            var url = isMyDishes ?
                "https://nt106.uitiot.vn/api/v1/monan/my-dishes" :
                "https://nt106.uitiot.vn/api/v1/monan/all";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue(tokenInfo.TokenType, tokenInfo.AccessToken);

                var body = new { current = currentPage, pageSize = pageSize };
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(body);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(url, content);
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Lỗi: {result}");
                    return;
                }

                dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                var listMonAn = data.data;

                FlowLayoutPanel panel = isMyDishes ? flowPanelMine : flowPanelAll;
                panel.Controls.Clear();

                if (listMonAn == null || listMonAn.Count == 0)
                {
                    panel.Controls.Add(new Label { Text = "Không có món ăn nào!", AutoSize = true });
                    return;
                }

                if (!isMyDishes)
                {
                    allMonAnList = ((IEnumerable<dynamic>)listMonAn).ToList();
                }

                foreach (var item in listMonAn)
                {
                    MonAn monAnControl = new MonAn();

                    monAnControl.SetData(
                        (int)item.id,
                        (string)item.ten_mon_an,
                        item.gia.ToString(),
                        (string)item.dia_chi,
                        (string)item.nguoi_dong_gop,
                        (string)item.hinh_anh,
                        isMyDishes // true nếu tab "Tôi Đóng Góp", false nếu tab "All"
                    );

                    panel.Controls.Add(monAnControl);
                }
            }
        }

        public void AddMonAnToMine(MonAn monAnControl)
        {
            flowPanelMine.Controls.Add(monAnControl);
        }

        private async void PageCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedTab == AllTabPage)
                await LoadMonAnAsync(false);
            else if (tabControl2.SelectedTab == ToiDongGopTabPage)
                await LoadMonAnAsync(true);

        }

        private async void PageSizeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedTab == AllTabPage)
                await LoadMonAnAsync(false);
            else if (tabControl2.SelectedTab == ToiDongGopTabPage)
                await LoadMonAnAsync(true);
        }


        private void HomNayAn_Click(object sender, EventArgs e)
        {
            if (allMonAnList == null || allMonAnList.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn trống! Vui lòng load tab All trước.");
                return;
            }

            Random rnd = new Random();
            var randomMon = allMonAnList[rnd.Next(allMonAnList.Count)];

            // Lấy thông tin món ăn
            string tenMon = randomMon.ten_mon_an;
            string gia = randomMon.gia.ToString();
            string diaChi = randomMon.dia_chi;
            string nguoiDongGop = randomMon.nguoi_dong_gop;
            string hinhAnh = randomMon.hinh_anh;

            // Truyền vào form HomNayAn
            HomNayAn homNayAnForm = new HomNayAn(tenMon, gia, diaChi, nguoiDongGop, hinhAnh);
            homNayAnForm.Show();
        }




    }

}
