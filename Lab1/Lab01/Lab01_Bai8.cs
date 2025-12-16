using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Bai8 : Form
    {

        public Bai8()
        {
            InitializeComponent();
        }
        private List<string> DanhSachMonAn = new List<string>
        {
            "Bún riêu",
            "Bún thịt nướng",
            "Cơm tấm sườn trứng",
            "Phở",
            "Gỏi cuốn"
        };

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (BangThucAn.SelectedIndex != -1)
            {
                BangThucAn.Items.RemoveAt(BangThucAn.SelectedIndex);

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món ăn để xóa.");
            }
        }

        private void Them_Click(object sender, EventArgs e)
        {

            string MonAnMoi = MonAnVao.Text.Trim();

            if (!string.IsNullOrEmpty(MonAnMoi))
            {
                BangThucAn.Items.Add(MonAnMoi);

                MonAnVao.Clear();
                MonAnVao.Focus(); 
            }
            else
            {

                MessageBox.Show("Vui lòng nhập tên món ăn!", "Cảnh báo");
            }

        }

        private void Bai8_Load(object sender, EventArgs e)
        {
            BangThucAn.Items.AddRange(DanhSachMonAn.ToArray());

        }

        private void Tim_Click(object sender, EventArgs e)
        {
            KetQua.Clear();
            if (BangThucAn.Items.Count == 0)
            {
                KetQua.Text = "Không có món ăn nào trong danh sách!";
                return;
            }

           
            Random random = new Random();


            int IndexNgauNhien = random.Next(0, BangThucAn.Items.Count);


            string MonAnHomNay = BangThucAn.Items[IndexNgauNhien].ToString();

            KetQua.Text = MonAnHomNay;
        
    }
    }
}
