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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void NutTim_Click(object sender, EventArgs e)
        {
            if (NgayThangNamSinh.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại!");
                NgayThangNamSinh.Value = DateTime.Now;
                return;
            }
            DateTime Ngay = NgayThangNamSinh.Value;
            int day = Ngay.Day;
            int month = Ngay.Month;
            string cung = "";

            switch (month)
            {
                case 1:
                    cung = (day <= 20) ? "Ma Kết ♑" : "Bảo Bình ♒";
                    break;
                case 2:
                    cung = (day <= 19) ? "Bảo Bình ♒" : "Song Ngư ♓";
                    break;
                case 3:
                    cung = (day <= 20) ? "Song Ngư ♓" : "Bạch Dương ♈";
                    break;
                case 4:
                    cung = (day <= 20) ? "Bạch Dương ♈" : "Kim Ngưu ♉";
                    break;
                case 5:
                    cung = (day <= 21) ? "Kim Ngưu ♉" : "Song Tử ♊";
                    break;
                case 6:
                    cung = (day <= 21) ? "Song Tử ♊" : "Cự Giải ♋";
                    break;
                case 7:
                    cung = (day <= 22) ? "Cự Giải ♋" : "Sư Tử ♌";
                    break;
                case 8:
                    cung = (day <= 22) ? "Sư Tử ♌" : "Xử Nữ ♍";
                    break;
                case 9:
                    cung = (day <= 23) ? "Xử Nữ ♍" : "Thiên Bình ♎";
                    break;
                case 10:
                    cung = (day <= 23) ? "Thiên Bình ♎" : "Thần Nông ♏";
                    break;
                case 11:
                    cung = (day <= 22) ? "Thần Nông ♏" : "Nhân Mã ♐";
                    break;
                case 12:
                    cung = (day <= 21) ? "Nhân Mã ♐" : "Ma Kết ♑";
                    break;

            }
            KetQua.Text += cung;

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
