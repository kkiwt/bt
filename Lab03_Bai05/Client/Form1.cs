using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        private SocketClient client = new SocketClient();
        public Form1()
        {
            InitializeComponent();
            SetupClient();
        }

        private void SetupClient()
        {
            if(!client.Connect())
            {
                MessageBox.Show("Không thể kết nối tới Server!", "Lỗi kết nối", MessageBoxButtons.OK);
            }

            cbTuyChon.Items.Add("Cá nhân");
            cbTuyChon.Items.Add("Cộng đồng");

            cbTuyChon.SelectedIndex = 0;
            cbQuyenHan.SelectedIndex = 0;

            this.FormClosed += (s, e) => client.Disconnect();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbTuyChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private string imagepath = "";
        private void btnThemHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (pBThemHinhAnh.Image != null)
                    pBThemHinhAnh.Image.Dispose();

                pBThemHinhAnh.Image = Image.FromFile(ofd.FileName);
                pBThemHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;

                imagepath = ofd.FileName;
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (!client.IsConnected)
            {
                MessageBox.Show("Chưa kết nốii tới Server", "Lỗi", MessageBoxButtons.OK);
            }
            else
            {
                string TenMon = tbTenMonAn.Text.Trim();
                string HinhAnh = imagepath;
                string TenNguoiDongGop = tbNguoiDongGop.Text.Trim();
                string QuyenHan = cbQuyenHan.SelectedItem.ToString();
                string IDNCC = tbID.Text.Trim();

                if (string.IsNullOrEmpty(TenMon))
                {
                    MessageBox.Show("Vui lòng nhập tên món ăn", "Thiếu dữ liệu", MessageBoxButtons.OK);
                    return;
                }
                else if (string.IsNullOrEmpty(TenNguoiDongGop))
                {
                    MessageBox.Show("Vui lòng nhập người đóng góp", "Thiếu dữ liệu", MessageBoxButtons.OK);
                    return;
                }
                else if (string.IsNullOrEmpty(imagepath))
                {
                    MessageBox.Show("Vui lòng chọn hình ảnh", "Thiếu dữ liệu", MessageBoxButtons.OK);
                    return;
                }
                if (string.IsNullOrWhiteSpace(IDNCC))
                {
                    MessageBox.Show("Vui lòng nhập ID người đóng góp.", "Thiếu thông tin");
                    return;
                }

                string request = $"THEM_MON|{TenNguoiDongGop}|{TenMon}|{HinhAnh}|{QuyenHan}|{IDNCC}";
                string response = client.SendRequest(request);

                string[] parts = response.Split('|');
                if (parts[0] == "OK")
                {
                    MessageBox.Show("Thêm món ăn thành công!", "Thành công", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"Lỗi Server: {parts[1]}", "Lỗi Thêm Món");
                }
            }
        }

        private void lbKetQua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHomNayAnGi_Click(object sender, EventArgs e)
        {
            if (!client.IsConnected)
            {
                MessageBox.Show("Chưa kết nối Server.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idncc = tbID.Text.Trim();
            string tuychon = cbTuyChon.SelectedItem.ToString();
            string request = "";

            if (tuychon == "Cá nhân")
            {
                if (string.IsNullOrWhiteSpace(idncc))
                {
                    MessageBox.Show("Vui lòng nhập ID người đóng góp để chọn món Cá nhân.", "Thiếu thông tin", MessageBoxButtons.OK);
                    return;
                }

                request = $"CHON_MON|CANHAN|{idncc}";
            }
            else
            {
                request = "CHON_MON|CONGDONG";
            }

            string response = client.SendRequest(request);

            string[] parts = response.Split('|');
            if (parts[0] == "OK" && parts.Length >= 4)
            {
                lbKetQua.Items.Clear();
                lbKetQua.Items.Add($"Món ăn đề xuất: {parts[1]}");
                lbKetQua.Items.Add($"Đóng góp bởi: {parts[3]}");

                string tenMon = parts[1];
                string imagePath = parts[2];
                ShowImageFood(imagePath);
            }
            else
            {
                lbKetQua.Text = $"Lỗi: {parts[1]}";
            }
        }

        private void ShowImageFood(string imagePath)
        {
            try
            {
                if (!System.IO.File.Exists(imagePath))
                {
                    pictureBoxMonAn.Image = null;
                    return;
                }

                pictureBoxMonAn.Image = Image.FromFile(imagePath);

                pictureBoxMonAn.SizeMode = PictureBoxSizeMode.Zoom;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hiển thị ảnh: {ex.Message}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTuyChon_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

    }
}
