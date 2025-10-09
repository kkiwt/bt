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
    public partial class Lab2_Bai1 : Form
    {
        public Lab2_Bai1()
        {
            InitializeComponent();
        }

        private void Lab2_Bai1_Load(object sender, EventArgs e)
        {

        }

        private void DocFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader = new StreamReader("input1_kkiwt.txt"))
                {
                    NoiDungFile.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show($"Lỗi Đọc File: {ex.Message}");
            }

        }

        private void GhiFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("output1_kkiwt.txt"))
                {
                    writer.Write(NoiDungFile.Text);
                }
                MessageBox.Show("Đã ghi file thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi ghi file: {ex.Message}");

            }
        }
    }
}
