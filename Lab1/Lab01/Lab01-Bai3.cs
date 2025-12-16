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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void SoNguyenNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void NutTim_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(SoNguyenNhap.Text.Trim(), out int num) == false)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }
            int num1 = int.Parse(SoNguyenNhap.Text.Trim());
            if (num1 > 9 || num1 < 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }
            switch (int.Parse(SoNguyenNhap.Text))
            {
                case 0:
                    KetQua.Text = "Không";
                    break;
                case 1:
                    KetQua.Text = "Một";
                    break;
                case 2:
                    KetQua.Text = "Hai";
                    break;
                case 3:
                    KetQua.Text = "Ba";
                    break;
                case 4:
                    KetQua.Text = "Bốn";
                    break;
                case 5:
                    KetQua.Text = "Năm";
                    break;
                case 6:
                    KetQua.Text = "Sáu";
                    break;
                case 7:
                    KetQua.Text = "Bảy";
                    break;
                case 8:
                    KetQua.Text = "Tám";
                    break;
                case 9:
                    KetQua.Text = "Chín";
                    break;








            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoNguyenNhap.Clear();
            KetQua.Clear();
        }

        private void NangCao_Click(object sender, EventArgs e)
        {
            Bai3_NangCao BaiNangCao = new Bai3_NangCao();
            BaiNangCao.ShowDialog();
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void KetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
