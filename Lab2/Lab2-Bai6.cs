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


        private void SetupListView()
        {
            this.BangThucAnList.FullRowSelect = true;
            this.BangThucAnList.GridLines = true;
            this.HinhAnhMonAn.SizeMode = PictureBoxSizeMode.Zoom;
        }

      
        private void LoadMonAnToListView()
        {
            BangThucAnList.Items.Clear();
            List<MonAn> monAns = DataAccess.LoadMonAn(); // Load món ăn từ database ở file DataAccess vào ListView

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
            DataAccess.InitializeDatabase();
            LoadMonAnToListView();
            NguoiDongGop.Text = "Người đóng góp: [Chưa chọn]";
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string selectedImagePath = "default.jpg"; // nếu không được thêm hình từ trước thì dùng ảnh mặt định

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (BangThucAnList.SelectedItems.Count > 0)
            {
                var selectedMonAn = BangThucAnList.SelectedItems[0].Tag as MonAn;

                if (selectedMonAn != null)
                {
                    DataAccess.DeleteMonAn(selectedMonAn.IDMA); 
                    MessageBox.Show($"Đã xóa món ăn: {selectedMonAn.TenMonAn}", "Thông báo");
                    LoadMonAnToListView(); // Cập nhật lại danh sách sau khi xóa
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
            string NguoiDongGopMoi = TenNguoiDongGop.Text.Trim();

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
                // Tìm hoặc tạo ID Người đóng góp
                int idNcc = DataAccess.GetOrCreateNguoiDungId(NguoiDongGopMoi);

                // Tìm đường dẫn file ảnh
                string tenFileAnh = Path.GetFileName(selectedImagePath);

                if (selectedImagePath != "default.jpg" && File.Exists(selectedImagePath)) // nếu file được chọn khác ảnh mặc định
                {
                    string targetPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, tenFileAnh); // tại file bin/debug, không chọn ảnh ở đây được. Nếu chọn ở đây ==> báo lỗi
                    try
                    {
                        File.Copy(selectedImagePath, targetPath, true);
                    }
                    catch (Exception fileEx)
                    {
                        MessageBox.Show($"Lỗi sao chép file ảnh: {fileEx.Message}", "Lỗi File");
                    }
                }


                DataAccess.AddMonAn(MonAnMoi, tenFileAnh, idNcc); // thêm món ăn


                MonAnVao.Clear();
                TenNguoiDongGop.Clear(); 
                selectedImagePath = "default.jpg"; // Đặt lại về ảnh mặc định
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

            // Lấy món ăn ngẫu nhiên từ database
            var monAnNgauNhien = DataAccess.GetRandomMonAn();

            if (monAnNgauNhien != null)
            {
                KetQua.Text = monAnNgauNhien.TenMonAn;
                NguoiDongGop.Text = $"Người đóng góp: {monAnNgauNhien.TenNguoiDongGop}";
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


        private void ThemAnh_Click(object sender, EventArgs e) // Không chọn ảnh từ thư mục bin
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