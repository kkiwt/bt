using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Lab2;


namespace Lab02
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            Lab2_Bai1 Bai1 = new Lab2_Bai1();

            Bai1.ShowDialog();

        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            Lab2_Bai2 Bai2 = new Lab2_Bai2();

            Bai2.ShowDialog();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            Lab2_Bai3 Bai3 = new Lab2_Bai3();
            Bai3.ShowDialog();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            Lab2_Bai4 Bai4 = new Lab2_Bai4();
            Bai4.ShowDialog();
        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            Bai4 Bai5 = new Bai4();
            Bai5.ShowDialog(); // Bai 5 lab 2 la bai 4 lab 1
        }

        private void Bai6_Click(object sender, EventArgs e)
        {
            Bai8 bai8 = new Bai8();
            bai8.ShowDialog();
        }

        private void Bai7_Click(object sender, EventArgs e)
        {
            Lab2_Bai7 Bai7 = new Lab2_Bai7();
            Bai7.ShowDialog();

        }
    }
}


