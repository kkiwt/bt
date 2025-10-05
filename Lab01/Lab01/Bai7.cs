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
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void PhanTich_Click(object sender, EventArgs e)
        {
            KetQua.Clear();
            string input = DuLieuNhap.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập thông tin!");
                return;
            }

            string[] parts = input.Split(',');

            if (parts.Length < 2)
            {
                MessageBox.Show("Sai format hoặc Phải có họ tên và ít nhất 1 điểm thi một môn.");
                return;
            }

            string HoTen = parts[0].Trim();
            double[] Diem;
            try
            {
                Diem = parts.Skip(1).Select(s => double.Parse(s.Trim())).ToArray();
                if (Diem.Any(d => d < 0 || d > 10))
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng 0 - 10!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Điểm phải là số hợp lệ, phân cách bằng dấu ','");
                return;
            }


            KetQua.AppendText($"Họ và tên: {HoTen}\r\n");

            for (int i = 0; i < Diem.Length; i++)
            {
                KetQua.AppendText($"Môn {i + 1}: {Diem[i]}\r\n");
            }

            double DiemTB = Diem.Average();
            KetQua.AppendText($"\r\nĐiểm trung bình: {DiemTB:F2}\r\n");


            double Max = Diem.Max();
            double Min = Diem.Min();
            int MonMax = Array.IndexOf(Diem, Max) + 1;
            int MonMin = Array.IndexOf(Diem, Min) + 1;
            KetQua.AppendText($"Môn điểm cao nhất: Môn {MonMax} ({Max})\r\n");
            KetQua.AppendText($"Môn điểm thấp nhất: Môn {MonMin} ({Min})\r\n");

            int MonDau = Diem.Count(d => d >= 5);
            int MonKhongDau = Diem.Length - MonDau;
            KetQua.AppendText($"Số môn đậu: {MonDau}\r\n");
            KetQua.AppendText($"Số môn không đậu: {MonKhongDau}\r\n");

            string xepLoai = "";
            if (DiemTB >= 8 && Diem.All(d => d >= 6.5))
                xepLoai = "Giỏi";
            else if (DiemTB >= 6.5 && Diem.All(d => d >= 5))
                xepLoai = "Khá";
            else if (DiemTB >= 5 && Diem.All(d => d >= 3.5))
                xepLoai = "Trung Bình";
            else if (DiemTB >= 3.5 && Diem.All(d => d >= 2))
                xepLoai = "Yếu";
            else
                xepLoai = "Kém";

            KetQua.AppendText($"Xếp loại: {xepLoai}\r\n");

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
