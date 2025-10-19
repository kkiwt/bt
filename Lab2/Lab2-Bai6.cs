using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite; 

namespace Lab2
{
    public partial class Bai8 : Form
    {


        public Bai8()
        {
            InitializeComponent();
            SetupListView();
        }

        // Cấu hình ListView 
        private void SetupListView()
        {


            this.BangThucAnList.FullRowSelect = true;
            this.BangThucAnList.GridLines = true;


            // Thiết lập PictureBox
            this.HinhAnhMonAn.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // Phương thức tải dữ liệu từ DB vào ListView
        private void LoadMonAnToListView()
        {
            BangThucAnList.Items.Clear();
            // Lấy dữ liệu từ DataAccess
            List<MonAn> monAns = DataAccess.LoadMonAn();

            foreach (var monAn in monAns)
            {
                var item = new ListViewItem(new[]
                {
                    monAn.IDMA.ToString(),
                    monAn.TenMonAn,
                    monAn.TenNguoiDongGop
                });

                // Lưu đối tượng MonAn vào Tag để dễ dàng truy xuất ID khi Xóa
                item.Tag = monAn;

                BangThucAnList.Items.Add(item);
            }
        }

        private void Bai8_Load(object sender, EventArgs e)
        {
            // 1. Khởi tạo Database (tạo bảng và chèn dữ liệu mẫu nếu chưa có)
            DataAccess.InitializeDatabase();
            // 2. Tải dữ liệu vào ListView để hiển thị danh sách ban đầu
            LoadMonAnToListView();

            // Đặt Label Người đóng góp về trạng thái ban đầu
            NguoiDongGop.Text = "Người đóng góp: [Chưa chọn]";
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string selectedImagePath = "default.jpg";

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (BangThucAnList.SelectedItems.Count > 0)
            {
                // Lấy đối tượng MonAn từ Tag
                var selectedMonAn = BangThucAnList.SelectedItems[0].Tag as MonAn;

                if (selectedMonAn != null)
                {
                    DataAccess.DeleteMonAn(selectedMonAn.IDMA); // Xóa trong DB
                    MessageBox.Show($"Đã xóa món ăn: {selectedMonAn.TenMonAn}", "Thông báo");
                    LoadMonAnToListView(); // Cập nhật lại danh sách trên Form
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món ăn để xóa.", "Cảnh báo");
            }
        }


        private void Them_Click(object sender, EventArgs e)
        {
            string MonAnMoi = MonAnVao.Text.Trim();
            string NguoiDongGopMoi = TenNguoiDongGop.Text.Trim(); // Giả định có TextBox này

            if (string.IsNullOrEmpty(MonAnMoi))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!", "Cảnh báo");
                return;
            }

            if (string.IsNullOrEmpty(NguoiDongGopMoi))
            {
                MessageBox.Show("Vui lòng nhập tên người đóng góp!", "Cảnh báo");
                return;
            }

            try
            {
                // 1. Tìm hoặc tạo ID Người đóng góp
                int idNcc = DataAccess.GetOrCreateNguoiDungId(NguoiDongGopMoi);

                // 2. Xử lý file ảnh
                string tenFileAnh = Path.GetFileName(selectedImagePath);

                // Bạn cần sao chép ảnh vào thư mục chạy (bin/Debug) để DB có thể tham chiếu
                // Nếu ảnh không phải là 'default.jpg' và tồn tại, thực hiện sao chép
                if (selectedImagePath != "default.jpg" && File.Exists(selectedImagePath))
                {
                    string targetPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, tenFileAnh);
                    // Dùng Try/Catch để tránh lỗi nếu file đang được sử dụng
                    try
                    {
                        File.Copy(selectedImagePath, targetPath, true);
                    }
                    catch (Exception fileEx)
                    {
                        MessageBox.Show($"Lỗi sao chép file ảnh: {fileEx.Message}", "Lỗi File");
                        // Tiếp tục sử dụng tên file nhưng không đảm bảo ảnh đã có trong thư mục chạy
                    }
                }

                // 3. Thêm món ăn với tên file ảnh và IDNCC
                DataAccess.AddMonAn(MonAnMoi, tenFileAnh, idNcc);

                // Cập nhật giao diện và đặt lại trạng thái
                MonAnVao.Clear();
                // TenNguoiDongGopVao.Clear(); // Tùy chọn: xóa tên người đóng góp
                selectedImagePath = "default.jpg"; // Đặt lại về ảnh mặc định
                                                   // Cập nhật PictureBox để hiển thị rằng ảnh đã được reset (nếu cần)
                                                   // HinhAnhMonAn.Image = null; 

                MonAnVao.Focus();
                LoadMonAnToListView();

                MessageBox.Show($"Đã thêm món ăn '{MonAnMoi}' thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Lỗi DB");
            }
        }
        private void Tim_Click(object sender, EventArgs e)
        {
            KetQua.Clear();
            HinhAnhMonAn.Image = null;
            NguoiDongGop.Text = "Người đóng góp: [Đang tìm...]";

            // Lấy món ăn ngẫu nhiên từ DB
            var monAnNgauNhien = DataAccess.GetRandomMonAn();

            if (monAnNgauNhien != null)
            {
                // 1. Hiển thị Tên Món Ăn
                KetQua.Text = monAnNgauNhien.TenMonAn;


                NguoiDongGop.Text = $"Người đóng góp: {monAnNgauNhien.TenNguoiDongGop}";

                // 3. Hiển thị Hình Ảnh
                string imagePath = monAnNgauNhien.HinhAnh;
                if (File.Exists(imagePath))
                {
                    try
                    {
                        // Tạo bản sao của ảnh để file không bị khóa, cho phép Xóa/Ghi
                        using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                        {
                            HinhAnhMonAn.Image = Image.FromStream(stream);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi tải hình ảnh: {ex.Message}", "Lỗi File");
                        HinhAnhMonAn.Image = null;
                    }
                }
                else
                {
                    HinhAnhMonAn.Image = null;

                }
            }
            else
            {
                KetQua.Text = "Không có món ăn nào trong danh sách!";
                NguoiDongGop.Text = "Người đóng góp: Không có";
            }
        }

        private void TenNguoiDongGop_TextChanged(object sender, EventArgs e)
        {

        }


        private void ThemAnh_Click(object sender, EventArgs e) // Không chèn ảnh từ thư mục bin
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;

                if (AnhChen.Image != null)
                {
                    AnhChen.Image.Dispose();
                    AnhChen.Image = null; // Gán null để PictureBox không còn giữ tham chiếu
                }

                try
                {
                    using (var stream = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
                    {

                        AnhChen.Image = new Bitmap(stream);
                    }

                    MessageBox.Show($"Đã chọn ảnh: {Path.GetFileName(selectedImagePath)}", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi hiển thị hình ảnh: {ex.Message}", "Lỗi File");
                    selectedImagePath = "default.jpg";
                    AnhChen.Image = null;
                }
            }
        }
    }
}