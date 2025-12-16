using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class FormDatVe : Form
    {
        public FormDatVe()
        {
            InitializeComponent();

            DanhSachPhimCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            RapCombo.DropDownStyle = ComboBoxStyle.DropDownList;

            DanhSachPhimCombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            RapCombo.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            await Data.LoadFilmData();

            DanhSachPhimCombo.Items.Clear();
            foreach (var film in Data.filmData.Keys)
                DanhSachPhimCombo.Items.Add(film);

            DanhSachPhimCombo.SelectedIndex = -1;
            RapCombo.SelectedIndex = -1;
            NoiDungThanhToan.ReadOnly = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RapCombo.Items.Clear();
            if (DanhSachPhimCombo.SelectedItem == null) return;

            string film = DanhSachPhimCombo.SelectedItem.ToString();

            if (Data.filmData.ContainsKey(film))
                RapCombo.Items.AddRange(Data.filmData[film].Theaters.ToArray());

            ResetSeatColors();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string film = DanhSachPhimCombo.SelectedItem?.ToString();
            string theater = RapCombo.SelectedItem?.ToString();

            ResetSeatColors();

            if (film != null && theater != null)
                InitSeatColors(film, theater);
        }

        void ResetSeatColors()
        {
            foreach (Control ctrl in NoiChuaGhe.Controls)
                if (ctrl is Button btn)
                    btn.BackColor = Color.White;
        }

        void InitSeatColors(string film, string theater)
        {
            if (!Data.bookedSeats.ContainsKey(film)) return;
            if (!Data.bookedSeats[film].ContainsKey(theater)) return;

            var used = Data.bookedSeats[film][theater];

            foreach (Control ctrl in NoiChuaGhe.Controls)
            {
                if (ctrl is Button btn)
                {
                    if (used.Contains(btn.Text))
                        btn.BackColor = Color.Red;
                }
            }
        }

        private void AllButtons_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string seat = btn.Text;

            string film = DanhSachPhimCombo.SelectedItem?.ToString();
            string theater = RapCombo.SelectedItem?.ToString();

            if (film == null || theater == null) return;

            // Ghế đã đặt?
            if (Data.bookedSeats.ContainsKey(film) &&
                Data.bookedSeats[film].ContainsKey(theater) &&
                Data.bookedSeats[film][theater].Contains(seat))
            {
                MessageBox.Show("Ghế này đã được đặt!");
                return;
            }
            string searchString = $"Phim: {film} | Rạp: {theater} | Ghế: {seat}";
            var index = Data.choosingSeat.FindIndex(x => x.Film == film && x.Theater == theater && x.Seat == seat);

            if (index >= 0)
            {
                Data.choosingSeat.RemoveAt(index);
                btn.BackColor = Color.White;
                var lines = NoiDungThanhToan.Lines.ToList();
                int lineToRemove = lines.FindIndex(line => line.StartsWith(searchString));
                if (lineToRemove >= 0)
                {
                    lines.RemoveAt(lineToRemove);
                    NoiDungThanhToan.Lines = lines.ToArray();
                }
            }
            else
            {
                Data.choosingSeat.Add((film, theater, seat));
                var filmInfo = Data.filmData[film];
                btn.BackColor = Color.Green;
                decimal price = Data.CalculatePrice(filmInfo.BasePrice, seat);
                NoiDungThanhToan.AppendText($"{searchString} | Giá: {price} \n");
            }
        }

        private void NutThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TenText.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người đặt vé!", "Lỗi");
                return;
            }
            if (DanhSachPhimCombo.SelectedIndex == -1 || RapCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phim và rạp trước khi đặt!");
                return;
            }
            if (Data.choosingSeat.Count == 0)
            {
                MessageBox.Show("Chưa chọn ghế nào!");
                return;
            }

            foreach (var seat in Data.choosingSeat)
                Data.BookSeat(seat.Film, seat.Theater, seat.Seat);


            decimal totalPrice = 0;
            foreach (var seat in Data.choosingSeat)
            {
                var filmInfo = Data.filmData[seat.Film];
                totalPrice += Data.CalculatePrice(filmInfo.BasePrice, seat.Seat);
            }
            Data.choosingSeat.Clear();
            MessageBox.Show($"{TenText.Text} đã đặt vé thành công!\nTổng tiền: {totalPrice}đ", "Thông báo");

            ResetSeatColors();
            InitSeatColors(DanhSachPhimCombo.SelectedItem.ToString(), RapCombo.SelectedItem.ToString());
            NoiDungThanhToan.Clear();
            TenText.Clear();
        }
    }
}