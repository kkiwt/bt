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


namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}


