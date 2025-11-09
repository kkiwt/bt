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
using System.Security.Policy;

namespace Lab02
{
    public partial class Lab2_Bai4 : Form
    {
        public Lab2_Bai4()
        {
            InitializeComponent();
            UpdatePageInfo();
        }
        int IndexHienTai = -1;
        private void UpdatePageInfo()
        {
            if (DanhSachSinhVien.Count > 0 && IndexHienTai != -1)
            {
                Page.Text = $"{IndexHienTai + 1} / {DanhSachSinhVien.Count}";
            }
            else
            {
                Page.Text = "0 / 0";
            }
        }

        class SinhVien
        {
            public string HoTen { get; set; }
            public int MSSV { get; set; }
            public string DienThoai { get; set; }
            public float DiemMon1 { get; set; }
            public float DiemMon2 { get; set; }
            public float DiemMon3 { get; set; }

            public float DiemTB { get { return TinhDiemTB(); } }

            public float TinhDiemTB()
            {
                return (DiemMon1 + DiemMon2 + DiemMon3) / 3.0f;
            }
            public SinhVien() { }
            public SinhVien(string name = "", int ms = 0, string sdt = "", float mon1 = 0, float mon2 = 0, float mon3 = 0)
            {
                HoTen = name;
                MSSV = ms;
                DienThoai = sdt;
                DiemMon1 = mon1;
                DiemMon2 = mon2;
                DiemMon3 = mon3;
            }
        }

        private bool TryGetDiem(string So, out float diem)
        {
            if (float.TryParse(So, out diem))
            {
                if (diem >= 0.0f && diem <= 10.0f)
                    return true;
            }
            diem = 0.0f;
            return false;
        }
        private string ValidateSinhVienInput(string hoTen, string mssv, string sdt, string mon1, string mon2, string mon3)
        {
            if (string.IsNullOrWhiteSpace(hoTen)) return "Họ tên không được để trống.";
            if (mssv.Length != 8 || !int.TryParse(mssv, out _)) return "MSSV phải là 8 chữ số.";
            if (sdt.Length != 10 || !sdt.StartsWith("0") || !long.TryParse(sdt, out _))
                return "Số điện thoại phải là 10 chữ số và bắt đầu bằng số 0.";

            if (!TryGetDiem(mon1, out float Diem1)) return "Điểm Môn 1 không hợp lệ (0 - 10).";
            if (!TryGetDiem(mon2, out float Diem2)) return "Điểm Môn 2 không hợp lệ (0 - 10).";
            if (!TryGetDiem(mon3, out float Diem3)) return "Điểm Môn 3 không hợp lệ (0 - 10).";

            return "Thông tin hợp lệ!";
        }
        private void ClearInputFields()
        {
            NameGhi.Clear();
            IDGhi.Clear();
            SDTGhi.Clear();
            Diem1Ghi.Clear();
            Diem2Ghi.Clear();
            Diem3Ghi.Clear();
        }
        List<SinhVien> DanhSachSinhVien = new List<SinhVien>();
        private void UpdateRichTextBox(SinhVien sv)
        {
            BangNoiDung.AppendText($"Họ Tên: {sv.HoTen}\n");
            BangNoiDung.AppendText($"MSSV: {sv.MSSV}\n");
            BangNoiDung.AppendText($"SĐT: {sv.DienThoai}\n");
            BangNoiDung.AppendText($"Môn 1: {sv.DiemMon1}\n");
            BangNoiDung.AppendText($"Môn 2: {sv.DiemMon2}\n");
            BangNoiDung.AppendText($"Môn 3: {sv.DiemMon3}\n");
            BangNoiDung.AppendText($"\n");
        }
        private void DisplaySinhVien(SinhVien sv)
        {
            if (sv != null)
            {
                TenDoc.Text = sv.HoTen;
                IDDoc.Text = sv.MSSV.ToString("D8");
                SDTDoc.Text = sv.DienThoai;
                Diem1Doc.Text = sv.DiemMon1.ToString("F2");
                Diem2Doc.Text = sv.DiemMon2.ToString("F2");
                Diem3Doc.Text = sv.DiemMon3.ToString("F2");
                TrungBinhDoc.Text = sv.DiemTB.ToString("F2");
            }
            else
            {
                TenDoc.Clear();
                IDDoc.Clear();
                SDTDoc.Clear();
                Diem1Doc.Clear();
                Diem2Doc.Clear();
                Diem3Doc.Clear();
                TrungBinhDoc.Clear();
            }
        }


        static void SerializeToFileJson<T>(string filePath, T obj)
        {
            try
            {
                string json = JsonSerializer.Serialize(obj);
                File.WriteAllText(filePath, json);
                MessageBox.Show($"Dữ liệu được Serialized được ghi thành công đến {filePath} ");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong khi serializing dữ liệu: {ex.Message}");

            }
        }
        static T DeserializeFromFileJson<T>(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi Trong Khi Deserializing dữ liệu: {ex.Message}");
                return default;
            }
        }

        private void Lab2_Bai4_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ghi_Click(object sender, EventArgs e)
        {
            if (DanhSachSinhVien.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên trống. Vui lòng thêm dữ liệu trước.");
                return;
            }

            SerializeToFileJson("input4.txt", DanhSachSinhVien);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string hoTen = NameGhi.Text;
            string mssv = IDGhi.Text;
            string sdt = SDTGhi.Text;
            string mon1 = Diem1Ghi.Text;
            string mon2 = Diem2Ghi.Text;
            string mon3 = Diem3Ghi.Text;


            string validationResult = ValidateSinhVienInput(hoTen, mssv, sdt, mon1, mon2, mon3);

            if (validationResult != "Thông tin hợp lệ!")
            {
                MessageBox.Show(validationResult);
                return;
            }

            SinhVien sv = new SinhVien(hoTen, int.Parse(mssv), sdt, float.Parse(mon1), float.Parse(mon2), float.Parse(mon3));

            DanhSachSinhVien.Add(sv);
            UpdateRichTextBox(sv);
            ClearInputFields();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (DanhSachSinhVien.Count > 0)
            {

                IndexHienTai = (IndexHienTai - 1 + DanhSachSinhVien.Count) % DanhSachSinhVien.Count;
                DisplaySinhVien(DanhSachSinhVien[IndexHienTai]);
                UpdatePageInfo();
            }

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (DanhSachSinhVien.Count > 0)
            {
                IndexHienTai = (IndexHienTai + 1) % DanhSachSinhVien.Count; // trang 1/5, 2/5, 3/5, 4/5 ,5/5 de tranh bi vuot tam
                DisplaySinhVien(DanhSachSinhVien[IndexHienTai]);
                UpdatePageInfo();
            }

        }

        private void Doc_Click(object sender, EventArgs e)
        {


            List<SinhVien> ListDuocGhi = DeserializeFromFileJson<List<SinhVien>>("input4.txt");

            if (ListDuocGhi == null || ListDuocGhi.Count == 0)
            {
                DanhSachSinhVien.Clear();
                IndexHienTai = -1;
                DisplaySinhVien(null);
                UpdatePageInfo();
                return;

            }
            DanhSachSinhVien = ListDuocGhi;
            SerializeToFileJson("output4.txt", DanhSachSinhVien);
            IndexHienTai = 0;
            DisplaySinhVien(DanhSachSinhVien[IndexHienTai]);
            UpdatePageInfo();
        }
    }
}
