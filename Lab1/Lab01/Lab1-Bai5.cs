using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void Bai5_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            KetQua.Clear();
            int num1, num2;
            if (int.TryParse(A.Text, out num1) == false || int.TryParse(B.Text, out num2) == false)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                return;
            }
            if (comboBox1.Text == "Bảng Cửu Chương (B - A)")
            {
                int SoBangCuuChuong = Math.Abs(num2 - num1);


                string kq = "";
                kq = $"Bảng Cửu Chương {SoBangCuuChuong}: \r\n";
                for (int j = 1; j <= 10; j++)
                {
                    kq += $"{SoBangCuuChuong} x {j} = {SoBangCuuChuong * j}\r\n"; // \r\n xuong dong kieu text box
                }

                KetQua.Text = kq;
            }

            if (comboBox1.Text == "(A-B)!")
            {
                int SoGiaiThua = Math.Abs(num2 - num1);
                string kq = $"Giai thừa của {SoGiaiThua}  \r\n";
                long ketQua = 1;
                for (int i = 1; i <= SoGiaiThua; i++)
                {
                    ketQua *= i;
                    kq += $"{i}";
                    if (i < SoGiaiThua) kq += " x ";
                }

                kq += $" = {ketQua}";
                KetQua.Text = kq;

            }

            if (comboBox1.Text == "S = A mũ 1 + A mũ 2 +...+ A mũ B")
            {
                string kq = $"S = ";
                double S = 0;
                for (int i = 1; i <= num2; i++)
                {

                    S = S + Math.Pow(num1, i);
                    kq += $"{num1}^{i}";
                    if (i < num2) kq += " + ";

                }
                kq += $" = {S}";
                KetQua.Text = kq;
            }



        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
