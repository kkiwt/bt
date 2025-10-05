using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Lab01
{
    public partial class Bai3_NangCao : Form
    {
        public Bai3_NangCao()
        {
            InitializeComponent();
        }
        private string VietHoaTatCaChuCaiDau(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(input.ToLower());
        }

        string[] ChuSo = { "không", "một", "hai", "ba", "bốn", "năm",
                           "sáu", "bảy", "tám", "chín" };

        string[] DonViNhom = { "", "nghìn", "triệu", "tỷ" };
        private void NutTim_Click(object sender, EventArgs e)
        {
            if (int.TryParse(SoNguyenNhap.Text.Trim(), out int num) == false)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }
            int num1 = int.Parse(SoNguyenNhap.Text.Trim());
            if (num1 < 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }
            string input = SoNguyenNhap.Text.Trim();

            if (!long.TryParse(input, out long so) || input.Length > 12)
            {
                MessageBox.Show("Vui lòng nhập số nguyên có tối đa 12 chữ số!");
                return;
            }

            KetQua.Text = VietHoaTatCaChuCaiDau(DocSoThanhChu(so));
        }
        private string DocBaSo(int num)
        {
            int tram = num / 100;
            int chuc = (num % 100) / 10;
            int donvi = num % 10;
            string result = "";

            if (tram > 0)
            {
                result += ChuSo[tram] + " trăm";
                if (chuc == 0 && donvi > 0)
                    result += " linh";
            }

            if (chuc > 0)
            {
                if (chuc == 1)
                    result += " mười";
                else
                    result += " " + ChuSo[chuc] + " mươi";
            }

            if (donvi > 0)
            {
                if (chuc > 1 && donvi == 1)
                    result += " mốt";
                else if (donvi == 5 && chuc != 0)
                    result += " lăm";
                else
                    result += " " + ChuSo[donvi];
            }

            return result.Trim();
        }

        private string DocSoThanhChu(long so)
        {
            if (so == 0) return "Không";

            string ketQua = "";
            int i = 0;

            while (so > 0)
            {
                int baSo = (int)(so % 1000);
                if (baSo != 0)
                {
                    string doc = DocBaSo(baSo);
                    if (i > 0)
                        doc += " " + DonViNhom[i];
                    ketQua = doc + ", " + ketQua;
                }
                so /= 1000;
                i++;
            }

            return ketQua.Trim().Trim(',');
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            SoNguyenNhap.Clear();
            KetQua.Clear();
        }
    }
}
