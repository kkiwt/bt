using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace Lab02
{
    public partial class Bai4 : Form
    {
        private QuanLyPhim DuLieuPhim = new QuanLyPhim();
        private const string TrangThaiFile = "trangthai_ghe.json";

        public Bai4()
        {
            InitializeComponent();
        }

        public class Movie
        {
            public string TenPhim { get; set; }
            public int GiaChuan { get; set; }
            public List<int> PhongChieu { get; set; }
            public Dictionary<int, List<string>> GheDaBan { get; set; } = new Dictionary<int, List<string>>();
        }

        public class ThongKePhim
        {
            public string TenPhim { get; set; }
            public int SoLuongVeBanRa { get; set; }
            public int SoLuongVeTon { get; set; }
            public double TiLeVeBanRa { get; set; }
            public long DoanhThu { get; set; }
            public int XepHang { get; set; }

            [JsonIgnore]
            public const int TongSoGheMoiPhong = 15;
        }

        public class QuanLyPhim
        {
            public Dictionary<string, Movie> DanhSachPhim { get; set; } = new Dictionary<string, Movie>();
        }

        string LoaiVe(string ghe)
        {
            // Cắt bỏ phần " - Đã bán" nếu có
            ghe = ghe.Split('-')[0].Trim();
            string[] veVot = { "A1", "A5", "C1", "C5" };
            string[] veThuong = { "A2", "A3", "A4", "C2", "C3", "C4" };
            string[] veVIP = { "B1", "B2", "B3", "B4", "B5" };

            if (veVot.Contains(ghe)) return "Vé vớt";
            if (veThuong.Contains(ghe)) return "Vé thường";
            if (veVIP.Contains(ghe)) return "Vé VIP";
            return "Không xác định";
        }

        double HeSoGia(string ghe)
        {
            string loai = LoaiVe(ghe);
            if (loai == "Vé vớt") return 0.25;
            if (loai == "Vé thường") return 1;
            if (loai == "Vé VIP") return 2;
            return 0;
        }

        // --- HÀM LOADGHÉ ĐÃ SỬA LỖI LOGIC QUAN TRỌNG ---
        private void LoadGhe(CheckedListBox clb, string Row, int phong)
        {
            clb.Items.Clear();

            if (Phim.SelectedItem == null || !DuLieuPhim.DanhSachPhim.ContainsKey(Phim.SelectedItem.ToString())) return;

            string tenPhim = Phim.SelectedItem.ToString();
            var movie = DuLieuPhim.DanhSachPhim[tenPhim];

            // Đảm bảo Dictionary có khóa phòng chiếu trước khi truy cập
            if (!movie.GheDaBan.ContainsKey(phong))
                movie.GheDaBan[phong] = new List<string>();

            var gheDaBanCuaPhong = movie.GheDaBan[phong];

            for (int i = 1; i <= 5; i++)
            {
                string tenGhe = $"{Row}{i}";
                if (gheDaBanCuaPhong.Contains(tenGhe))
                    // Ghế đã bán: thêm label và trạng thái false (không được check)
                    clb.Items.Add($"{tenGhe} - Đã bán", false);
                else
                    // Ghế trống: thêm tên ghế và trạng thái false (không được check)
                    clb.Items.Add(tenGhe, false);
            }
        }


        private void DocDuLieuPhim(string filePath)
        {
            DuLieuPhim.DanhSachPhim.Clear();
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    string[] parts = line.Split(new[] { ',' }, 3);

                    if (parts.Length < 3 || !int.TryParse(parts[1].Trim(), out int gia) || gia <= 0)
                        continue;

                    var phongChieuList = parts[2].Split(',')
                                                    .Select(s => s.Trim())
                                                    .Where(s => int.TryParse(s, out _))
                                                    .Select(int.Parse)
                                                    .ToList();

                    if (phongChieuList.Count == 0) continue;

                    var phimMoi = new Movie
                    {
                        TenPhim = parts[0].Trim(),
                        GiaChuan = gia,
                        PhongChieu = phongChieuList
                    };

                    // Khởi tạo List<string> rỗng cho mỗi phòng chiếu của phim này
                    foreach (var phong in phimMoi.PhongChieu)
                        phimMoi.GheDaBan[phong] = new List<string>();

                    DuLieuPhim.DanhSachPhim[phimMoi.TenPhim] = phimMoi;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc file input5.txt: {ex.Message}", "Lỗi I/O");
            }
        }

        private void GhiTrangThaiGhe()
        {
            try
            {
                // Chỉ lưu trữ Dictionary<phòng, List<ghế đã bán>> cho mỗi phim
                var dataToSave = DuLieuPhim.DanhSachPhim.ToDictionary(
                    kvp => kvp.Key,
                    kvp => kvp.Value.GheDaBan
                );

                string json = JsonSerializer.Serialize(dataToSave, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(TrangThaiFile, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi ghi trạng thái ghế: {ex.Message}", "Lỗi I/O");
            }
        }

        private void DocTrangThaiGhe()
        {
            if (!File.Exists(TrangThaiFile)) return;

            try
            {
                string json = File.ReadAllText(TrangThaiFile);
                var savedData = JsonSerializer.Deserialize<Dictionary<string, Dictionary<int, List<string>>>>(json);

                if (savedData == null) return;

                // Gán dữ liệu ghế đã bán vào object Movie tương ứng trong DuLieuPhim
                foreach (var kvp in savedData)
                {
                    if (DuLieuPhim.DanhSachPhim.ContainsKey(kvp.Key))
                        DuLieuPhim.DanhSachPhim[kvp.Key].GheDaBan = kvp.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc trạng thái ghế: {ex.Message}", "Lỗi I/O");
            }
        }

        private async Task ThongKeVaXuatFile(string filePath)
        {
            if (DuLieuPhim.DanhSachPhim.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu phim để thống kê.");
                return;
            }

            // Cấu hình ProgressBar
            // (Giữ nguyên phần này)

            var listThongKe = new List<ThongKePhim>();

            foreach (var kvp in DuLieuPhim.DanhSachPhim)
            {
                var tenPhim = kvp.Key;
                var phim = kvp.Value;

                long doanhThu = 0;
                int veBanRa = 0;

                foreach (var phongKvp in phim.GheDaBan)
                {
                    veBanRa += phongKvp.Value.Count;
                    foreach (var ghe in phongKvp.Value)
                        doanhThu += (long)(phim.GiaChuan * HeSoGia(ghe));
                }

                // Tính toán số ghế tổng và tỉ lệ
                int tongSoGhe = phim.PhongChieu.Count * ThongKePhim.TongSoGheMoiPhong;
                int veTon = tongSoGhe - veBanRa;
                double tiLe = (tongSoGhe > 0) ? (double)veBanRa / tongSoGhe : 0;

                listThongKe.Add(new ThongKePhim
                {
                    TenPhim = tenPhim,
                    SoLuongVeBanRa = veBanRa,
                    SoLuongVeTon = veTon,
                    TiLeVeBanRa = Math.Round(tiLe, 4),
                    DoanhThu = doanhThu
                });

                // (Giữ nguyên phần ProgressBar)
            }

            // Xếp hạng phim theo Doanh Thu
            var sortedList = listThongKe.OrderByDescending(t => t.DoanhThu).ToList();
            for (int i = 0; i < sortedList.Count; i++)
                sortedList[i].XepHang = i + 1;

            // Xuất file JSON
            File.WriteAllText(filePath,
                JsonSerializer.Serialize(sortedList, new JsonSerializerOptions { WriteIndented = true }),
                Encoding.UTF8);

            // (Giữ nguyên phần ProgressBar)
            MessageBox.Show($"Đã xuất thống kê ra file {filePath}");
        }

        // --- Event Handlers ---

        private void Doc_Click(object sender, EventArgs e)
        {
            DocDuLieuPhim("input5.txt");
            DocTrangThaiGhe();
            if (DuLieuPhim.DanhSachPhim.Count > 0)
            {
                Phim.Items.Clear();
                foreach (var ten in DuLieuPhim.DanhSachPhim.Keys)
                    Phim.Items.Add(ten);
                Phim.SelectedIndex = 0;
            }
        }

        private void Ghi_Click(object sender, EventArgs e)
        {
            GhiTrangThaiGhe();
            MessageBox.Show("Đã lưu trạng thái ghế.");
        }

        private async void ThongKe_Click(object sender, EventArgs e)
        {
            // Cần có control progressBar1 trong Designer để hàm này chạy
            // Nếu chưa có, bạn sẽ gặp lỗi biên dịch ở đây.
            if (this.Controls.Find("progressBar1", true).FirstOrDefault() is ProgressBar progressBar)
            {
                progressBar.Visible = true;
            }
            await ThongKeVaXuatFile("output5.txt");
            if (this.Controls.Find("progressBar1", true).FirstOrDefault() is ProgressBar progressBar1)
            {
                progressBar1.Visible = false;
            }
        }

        private void Phim_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhongChieu.Items.Clear();
            PhongChieu.SelectedIndex = -1;

            GheA.Items.Clear();
            GheB.Items.Clear();
            GheC.Items.Clear();

            if (Phim.SelectedItem == null) return;

            string tenPhim = Phim.SelectedItem.ToString();
            if (!DuLieuPhim.DanhSachPhim.ContainsKey(tenPhim)) return;

            foreach (var phong in DuLieuPhim.DanhSachPhim[tenPhim].PhongChieu)
                PhongChieu.Items.Add($"Phòng {phong}");
        }

        // --- HÀM SELECTINDEXCHANGED ĐÃ SỬA LỖI LOGIC GỌI LOADGHE ---
        private void PhongChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            GheA.Items.Clear();
            GheB.Items.Clear();
            GheC.Items.Clear();

            if (PhongChieu.SelectedItem == null || Phim.SelectedItem == null) return;

            // Lấy số phòng an toàn (chỉ lấy số từ chuỗi "Phòng X")
            string digits = new string(PhongChieu.SelectedItem.ToString().Where(char.IsDigit).ToArray());
            if (!int.TryParse(digits, out int phong)) return;

            // Gọi hàm LoadGhe với số phòng đã xác định
            LoadGhe(GheA, "A", phong);
            LoadGhe(GheB, "B", phong);
            LoadGhe(GheC, "C", phong);
        }
        // ------------------------------------------------------------------

        private void MuaVe_Click(object sender, EventArgs e)
        {
            // (Giữ nguyên logic của bạn, logic này đã đúng)
            if (Phim.SelectedItem == null || PhongChieu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim và phòng chiếu!");
                return;
            }

            string tenKH = HoTen.Text.Trim();
            if (string.IsNullOrEmpty(tenKH))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return;
            }

            string tenPhim = Phim.SelectedItem.ToString();

            // Lấy số phòng an toàn
            string digits = new string(PhongChieu.SelectedItem.ToString().Where(char.IsDigit).ToArray());
            if (!int.TryParse(digits, out int phong)) return;

            var phim = DuLieuPhim.DanhSachPhim[tenPhim];

            if (!phim.GheDaBan.ContainsKey(phong))
            {
                MessageBox.Show("Lỗi: Phòng chiếu không tồn tại trong dữ liệu ghế đã bán.", "Lỗi hệ thống");
                return;
            }

            var gheDaBan = phim.GheDaBan[phong];

            // Lấy tất cả ghế đang được CHECK (chọn) và loại bỏ chuỗi " - Đã bán"
            var gheChonDeMua = GheA.CheckedItems.Cast<string>()
                                                .Concat(GheB.CheckedItems.Cast<string>())
                                                .Concat(GheC.CheckedItems.Cast<string>())
                                                .Select(g => g.Split('-')[0].Trim())
                                                .ToList();

            if (gheChonDeMua.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ghế!");
                return;
            }

            double tongTien = 0;
            var gheVuaMuaThanhCong = new List<string>();

            foreach (var g in gheChonDeMua)
            {
                // Kiểm tra ghế đã bán dựa trên dữ liệu TRẠNG THÁI (gheDaBan)
                if (gheDaBan.Contains(g))
                {
                    MessageBox.Show($"Ghế {g} đã được mua trước đó. Vui lòng bỏ chọn ghế này!", "Lỗi");
                    return;
                }

                tongTien += phim.GiaChuan * HeSoGia(g);
                gheVuaMuaThanhCong.Add(g);
            }

            // CẬP NHẬT TRẠNG THÁI GHẾ ĐÃ BÁN VÀO DỮ LIỆU CHÍNH
            foreach (var g in gheVuaMuaThanhCong)
            {
                gheDaBan.Add(g);
            }

            // Làm mới CheckedListBoxes để hiển thị ghế vừa mua là "Đã bán"
            PhongChieu_SelectedIndexChanged(null, null);

            // Hiển thị kết quả
            KetQua.Text = $"Khách hàng: {tenKH}\n" +
                          $"Phim: {tenPhim}\n" +
                          $"Phòng chiếu: {phong}\n" +
                          $"Ghế: {string.Join(", ", gheVuaMuaThanhCong)}\n" +
                          $"Tổng tiền: {tongTien:N0} đ";

            MessageBox.Show($"Mua vé thành công! Tổng tiền: {tongTien:N0} đ", "Thanh Toán");
            HoTen.Clear();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            DocDuLieuPhim("input5.txt");
            DocTrangThaiGhe();

            if (DuLieuPhim.DanhSachPhim.Count > 0)
            {
                Phim.Items.Clear();
                foreach (var ten in DuLieuPhim.DanhSachPhim.Keys)
                    Phim.Items.Add(ten);
                Phim.SelectedIndex = 0; // Tự động chọn phim đầu tiên
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            GhiTrangThaiGhe();
            this.Close();
        }

        private void GheA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}