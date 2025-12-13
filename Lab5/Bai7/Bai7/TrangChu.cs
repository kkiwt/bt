using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System;
using System.Buffers.Text;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using Supabase;



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
            if (tabControl2.SelectedTab == GmailTabPage)
            {

                TogglePagingControls(false);

                await LoadMonAnGmailAsync(); 
            }
            else
            {

                TogglePagingControls(true);


                if (tabControl2.SelectedTab == AllTabPage)
                    await LoadMonAnAsync(false); 
                else if (tabControl2.SelectedTab == ToiDongGopTabPage)
                    await LoadMonAnAsync(true); 
            }
        }


        private List<dynamic> myMonAnList = new List<dynamic>();

        private List<dynamic> gmailMonAnList = new List<dynamic>();




        private async void TrangChu_Load(object sender, EventArgs e)
        {
            try
            {

                await SupabaseHolder.InitializeAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi tạo Supabase: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            PageCombo.Items.AddRange(new string[] { "1", "2", "3", "4", "5" });
            PageSizeCombo.Items.AddRange(new string[] { "5", "10", "15", "20", "100" });
            PageCombo.SelectedIndex = 0;
            PageSizeCombo.SelectedIndex = 0;

            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Visible = false;

            await LoadMonAnAsync(false); // Load All (API)
            await LoadMonAnAsync(true);  // Load Tôi Đóng Góp (API)
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



        private void TogglePagingControls(bool visible)
        {

            label2.Visible = visible;      // "Page"
            label3.Visible = visible;      // "Page Size"
            PageCombo.Visible = visible;
            PageSizeCombo.Visible = visible;

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
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Value = 0;

            try
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


                    if (isMyDishes)
                    {
                        myMonAnList = ((IEnumerable<dynamic>)listMonAn).ToList();
                    }
                    else
                    {
                        allMonAnList = ((IEnumerable<dynamic>)listMonAn).ToList();
                    }



                    // Sau khi lấy listMonAn từ API
                    var limitedList = ((IEnumerable<dynamic>)listMonAn).Take(pageSize).ToList();

                    // Dùng limitedList thay vì listMonAn
                    progressBar1.Maximum = limitedList.Count;
                    int count = 0;
                    foreach (var item in limitedList)
                    {
                        MonAn monAnControl = new MonAn();
                        monAnControl.SetData(
                            (int)item.id,
                            (string)item.ten_mon_an,
                            item.gia.ToString(),
                            (string)item.dia_chi,
                            (string)item.nguoi_dong_gop,
                            (string)item.hinh_anh,
                            isMyDishes
                        );
                        panel.Controls.Add(monAnControl);

                        count++;
                        progressBar1.Value = count;
                        await Task.Delay(50);
                    }


                }
            }
            finally
            {
                progressBar1.Visible = false; // Ẩn khi hoàn tất
            }
        }


        public async Task LoadMonAnGmailAsync()
        {
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Value = 0;

            try
            {
                int currentPage = PageCombo.SelectedItem != null ? int.Parse(PageCombo.SelectedItem.ToString()) : 1;
                int pageSize = PageSizeCombo.SelectedItem != null ? int.Parse(PageSizeCombo.SelectedItem.ToString()) : 5;

                // Không dùng tuple deconstruction nếu version C# thấp:
                var rpcResult = await RpcGetMonAnGmailAsync(currentPage, pageSize, "ngay_them", "desc");
                var items = rpcResult.Items;
                var total = rpcResult.Total;

                // ✅ Lưu list để nút "Hôm Nay Ăn" pick ngẫu nhiên
                gmailMonAnList = items.ToList();

                flowPanelGmail.Controls.Clear();

                if (items == null || items.Count == 0)
                {
                    flowPanelGmail.Controls.Add(new Label { Text = "Không có món ăn nào từ Gmail!", AutoSize = true });
                    return;
                }

                progressBar1.Maximum = items.Count;
                int count = 0;

                foreach (var item in items)
                {
                    string id = item["id"]?.ToString() ?? "";
                    string ten = item["ten_mon_an"]?.ToString() ?? "";
                    string gia = item["gia"]?.ToString() ?? "0";
                    string diaChi = item["dia_chi"]?.ToString() ?? "";
                    string nguoiDongGop = item["nguoi_dong_gop"]?.ToString() ?? "";
                    string hinhAnh = item["hinh_anh"]?.ToString() ?? "";

                    var monAnControl = new MonAnGmail();
                    monAnControl.SetData(id, ten, gia, diaChi, nguoiDongGop, hinhAnh, true);

                    // (tuỳ chọn) co giãn theo panel
                    monAnControl.Width = flowPanelGmail.ClientSize.Width - 24;

                    flowPanelGmail.Controls.Add(monAnControl);
                    count++;
                    progressBar1.Value = count;
                    await Task.Delay(10);
                }
            }
            finally
            {
                progressBar1.Visible = false;
            }
        }






        private async Task<(List<dynamic> Items, int Total)> RpcGetMonAnGmailAsync(
            int current, int pageSize,
            string sortBy = "ngay_them",
            string sortDir = "desc")
        {
            await SupabaseHolder.InitializeAsync();
            var client = SupabaseHolder.Client;

            var payload = new
            {
                p_current = current,
                p_page_size = pageSize,
                p_sort_by = sortBy,
                p_sort_dir = sortDir
            };

            // Gọi RPC qua SDK
            var resp = await client.Rpc("get_monan_gmail_v2", payload);

            // ⬇️ Sửa ở đây: Content là string
            var jsonText = resp.Content;

            dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonText);

            var items = obj.items is Newtonsoft.Json.Linq.JArray
                ? ((IEnumerable<dynamic>)obj.items).ToList()
                : new List<dynamic>();

            int total = obj.total != null ? (int)obj.total : 0;

            return (items, total);
        }



        public async Task<bool> DeleteMonAnRpcAsync(string id)
        {
            try
            {
                await SupabaseHolder.InitializeAsync();
                var client = SupabaseHolder.Client;

                var payload = new { p_id = id };
                var resp = await client.Rpc("delete_monan_by_id", payload);

                var json = resp.Content; 
                if (bool.TryParse(json, out bool ok) && ok)
                {
                    MessageBox.Show("Xóa món ăn thành công!");
                    if (tabControl2.SelectedTab == GmailTabPage)
                        await LoadMonAnGmailAsync();
                    return true;
                }
                else
                {
                    MessageBox.Show($"Xóa thất bại: {json}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}");
                return false;
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
            Cursor = Cursors.WaitCursor;

            if (tabControl2.SelectedTab == GmailTabPage)
            {
                if (gmailMonAnList == null || gmailMonAnList.Count == 0)
                {
                    MessageBox.Show("Danh sách Gmail đang trống! Vui lòng vào Tab Gmail để load dữ liệu trước.");
                    return;
                }
                var rnd = new Random();
                var mon = gmailMonAnList[rnd.Next(gmailMonAnList.Count)];
                ShowRandomMonFromDynamic(mon);
            }

            if (tabControl2.SelectedTab == AllTabPage)
            {
                if (allMonAnList == null || allMonAnList.Count == 0)
                {
                    MessageBox.Show("Danh sách món ăn trống! Vui lòng load tab All trước.");
                    return;
                }

                Random rnd = new Random();
                var randomMon = allMonAnList[rnd.Next(allMonAnList.Count)];

                ShowRandomMon(randomMon);
            }
            else if (tabControl2.SelectedTab == ToiDongGopTabPage)
            {
                if (myMonAnList == null || myMonAnList.Count == 0)
                {
                    MessageBox.Show("Bạn chưa có món ăn nào trong danh sách đóng góp!");
                    return;
                }

                Random rnd = new Random();
                var randomMon = myMonAnList[rnd.Next(myMonAnList.Count)];

                ShowRandomMon(randomMon);
            }
            Cursor = Cursors.Default;
        }

        private void ShowRandomMon(dynamic mon)
        {
            string tenMon = mon.ten_mon_an;
            string gia = mon.gia.ToString();
            string diaChi = mon.dia_chi;
            string nguoiDongGop = mon.nguoi_dong_gop;
            string hinhAnh = mon.hinh_anh;

            HomNayAn homNayAnForm = new HomNayAn(tenMon, gia, diaChi, nguoiDongGop, hinhAnh);
            homNayAnForm.Show();
        }

        private void ShowRandomMonFromDynamic(dynamic mon)
        {
            string tenMon = mon["ten_mon_an"]?.ToString() ?? "";
            string gia = mon["gia"]?.ToString() ?? "0";
            string diaChi = mon["dia_chi"]?.ToString() ?? "";
            string nguoiDongGop = mon["nguoi_dong_gop"]?.ToString() ?? "";
            string hinhAnh = mon["hinh_anh"]?.ToString() ?? "";

            var f = new HomNayAn(tenMon, gia, diaChi, nguoiDongGop, hinhAnh);
            f.Show();
        }


        private void NutLogOut_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void NutLogOut_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }


        private void TaiDongGop_Click(object sender, EventArgs e)
        {
            var ds = new DanhSachGmail();
            ds.Owner = this; // ✅ rất quan trọng để callback về TrangChu
            ds.ShowDialog();
        }

    }

}
