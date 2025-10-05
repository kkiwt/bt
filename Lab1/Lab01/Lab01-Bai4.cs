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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
            foreach (var p in dsPhim.Keys)
                Phim.Items.Add(p);
        }

        // Cấu trúc dữ liệu phim
        Dictionary<string, (int giaChuan, List<int> phongChieu)> dsPhim = new Dictionary<string, (int, List<int>)>
        {
            { "Đào, phở và piano", (45000, new List<int>{1,2,3}) },
            { "Mai", (100000, new List<int>{2,3}) },
            { "Gặp lại chị bầu", (70000, new List<int>{1}) },
            { "Tarot", (90000, new List<int>{3}) },
        };

        string LoaiVe(string ghe)
        {
            string[] veVot = { "A1", "A5", "C1", "C5" };
            string[] veThuong = { "A2", "A3", "A4", "C2", "C3", "C4" };
            string[] veVIP = { "B1", "B2", "B3", "B4", "B5" }; // gia su B1 va B5 la ve VIP

            if (veVot.Contains(ghe)) return "Vé vớt";
            if (veThuong.Contains(ghe)) return "Vé thường";
            if (veVIP.Contains(ghe)) return "Vé VIP";
            return "Không xác định";
        }

        double HeSoGia(string ghe)
        {
            if (LoaiVe(ghe) == "Vé vớt") return 0.25;
            if (LoaiVe(ghe) == "Vé thường") return 1;
            if (LoaiVe(ghe) == "Vé VIP") return 2;
            return 0;
        }

        // Lưu trạng thái ghế đã mua theo phòng
        Dictionary<int, HashSet<string>> gheDaMua = new Dictionary<int, HashSet<string>>
        {
            { 1, new HashSet<string>() },
            { 2, new HashSet<string>() },
            { 3, new HashSet<string>() },
        };


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadGhe(CheckedListBox clb, string Row)
        {
            clb.Items.Clear();
            for (int i = 1; i <= 5; i++)
                clb.Items.Add($"{Row}{i}");
        }

        private void PhongChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            GheA.Items.Clear();
            GheB.Items.Clear();
            GheC.Items.Clear();
            LoadGhe(GheA, "A");
            LoadGhe(GheB, "B");
            LoadGhe(GheC, "C");
            string[] ghe = { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" };
            if (PhongChieu.SelectedItem == null) return;
            string[] parts = PhongChieu.SelectedItem.ToString().Split(' ');
            if (parts.Length < 2) return;
            int phong = int.Parse(parts[1]);




        }

        private void GheA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Phim_SelectedIndexChanged(object sender, EventArgs e)
        {

            PhongChieu.Items.Clear();
            PhongChieu.SelectedIndex = -1; 

            GheA.Items.Clear();
            GheB.Items.Clear();
            GheC.Items.Clear();

            var phim = Phim.SelectedItem.ToString();

            foreach (var phong in dsPhim[phim].phongChieu)
                PhongChieu.Items.Add($"Phòng {phong}");
        }

        

        private void MuaVe_Click(object sender, EventArgs e)
        {
            if (Phim.SelectedItem == null || PhongChieu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim và phòng chiếu!");
                return;
            }

            string tenKH = HoTen.Text.Trim();
            if (string.IsNullOrEmpty(tenKH))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return;
            }

            string tenPhim = Phim.SelectedItem.ToString();
            int phong = int.Parse(PhongChieu.SelectedItem.ToString().Split(' ')[1]);
            int giaChuan = dsPhim[tenPhim].giaChuan;

            var gheChon = new List<string>();
            gheChon.AddRange(GheA.CheckedItems.Cast<string>());
            gheChon.AddRange(GheB.CheckedItems.Cast<string>());
            gheChon.AddRange(GheC.CheckedItems.Cast<string>());


            if (gheChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ghế!");
                return;
            }


            foreach (var g in gheChon)
            {
                if (g.Contains("Đã bán"))
                {
                    MessageBox.Show($"Ghế {g} đã được mua!");
                    return;
                }
            }

            double tongTien = 0;
            phong = int.Parse(PhongChieu.SelectedItem.ToString().Split(' ')[1]);
            giaChuan = dsPhim[Phim.SelectedItem.ToString()].giaChuan;

            foreach (var g in gheChon)
            {
                tongTien += giaChuan * HeSoGia(g);
                gheDaMua[phong].Add(g);
            }


            KetQua.Text = $"Khách hàng: {HoTen.Text}\n" +
                          $"Phim: {Phim.SelectedItem}\n" +
                          $"Phòng chiếu: {phong}\n" +
                          $"Ghế: {string.Join(", ", gheChon)}\n" +
                          $"Tổng tiền: {tongTien:N0} đ";

        }

        private void KetQua_Click(object sender, EventArgs e)
        {

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }
    }
}
