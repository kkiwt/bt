using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace Lab02
{
    public partial class Lab2_Bai4 : Form
    {
        public Lab2_Bai4()
        {
            InitializeComponent();
        }

        class SinhVien
        { 
            public string HoTen { get; set; }
            public int MSSV { get; set; }
            public string DienThoai { get; set; }
            public float DiemMon1 { get; set; }
            public float DiemMon2 { get; set; }
            public float DiemMon3 { get; set; }

            public float DiemTB { get; set; }

            public float TinhDiemTB()
            {
                return (DiemMon1 + DiemMon2 +DiemMon3) / 3;
            }
            public SinhVien (string name, int ms, string sdt, float mon1, float mon2, float mon3)
            {
                HoTen = name;
                MSSV = ms;
                DienThoai = sdt;
                DiemMon1 = mon1;
                DiemMon2 = mon2;
                DiemMon3 = mon3;
            }

            
        }
        static void SerializeToFileJson<T> (string filePath, T obj)
        {
            try
            {
                string json = JsonSerializer.Serialize(obj);
            }
            catch(Exception ex)
            {

            }
        }
        private void Lab2_Bai4_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
