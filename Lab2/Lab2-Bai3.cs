using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab2_Bai3 : Form
    {
        public Lab2_Bai3()
        {
            InitializeComponent();
        }
        private double TinhBieuThucBangStack(string BieuThuc)
        {
            BieuThuc = BieuThuc.Replace(" ", "");

            Stack<double> values = new Stack<double>();
            Stack<char> Dau = new Stack<char>();

            for (int i = 0; i < BieuThuc.Length; i++)
            {
                if (char.IsDigit(BieuThuc[i]))
                {
                    string number = "";
                    while (i < BieuThuc.Length && (char.IsDigit(BieuThuc[i]) || BieuThuc[i] == '.'))
                    {
                        number += BieuThuc[i];
                        i++;
                    }
                    i--;
                    values.Push(double.Parse(number));
                }
                else if (BieuThuc[i] == '(')
                {
                    Dau.Push(BieuThuc[i]);
                }
                else if (BieuThuc[i] == ')')
                {
                    while (Dau.Peek() != '(')
                    {
                        values.Push(ApDungPhepTinh(Dau.Pop(), values.Pop(), values.Pop()));
                    }
                    Dau.Pop();
                }
                else if ("+-*/x:".Contains(BieuThuc[i]))
                {
                    while (Dau.Count > 0 && DoUuTien(Dau.Peek()) >= DoUuTien(BieuThuc[i]))
                    {
                        values.Push(ApDungPhepTinh(Dau.Pop(), values.Pop(), values.Pop()));
                    }
                    Dau.Push(BieuThuc[i]);
                }
            }

            while (Dau.Count > 0)
            {
                values.Push(ApDungPhepTinh(Dau.Pop(), values.Pop(), values.Pop()));
            }

            return values.Pop();
        }

        private int DoUuTien(char Dau)
        {
            if (Dau == '+' || Dau == '-') return 1;
            if (Dau == '*' || Dau == '/') return 2;
            return 0;
        }

        private double ApDungPhepTinh(char op, double b, double a)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case 'x': return a * b;
                case '/': return b != 0 ? a / b : double.NaN;
                case ':': return b != 0 ? a / b : double.NaN;
                default: return 0;
            }
        }

        private void Doc_Click(object sender, EventArgs e)
        {


            try
            {

                using (StreamReader Stream = new StreamReader("input3.txt"))
                {
                    BangNoiDung.Text = Stream.ReadToEnd();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi Đọc File: {ex.Message}");

            }
        }

        private void Ghi_Click(object sender, EventArgs e)
        {
            try
            {


                using (StreamWriter Writer = new StreamWriter("output3.txt"))
                {
                    string[] lines = BangNoiDung.Lines;
                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        try
                        {
                            double result = TinhBieuThucBangStack(line);
                            Writer.WriteLine($"{line} = {result}");
                        }
                        catch
                        {
                            Writer.WriteLine($"{line} = Lỗi biểu thức");
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi ghi file: {ex.Message}");

            }
            try
            {

                using (StreamReader Stream = new StreamReader("output3_kkiwt.txt"))
                {
                    BangNoiDung.Text = Stream.ReadToEnd();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi Đọc File Kết Quả: {ex.Message}");

            }

        }

        private void Lab2_Bai3_Load(object sender, EventArgs e)
        {

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
