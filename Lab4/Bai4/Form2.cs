using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            await Data.LoadFilmData();

            comboBox1.Items.Clear();
            foreach (var film in Data.filmData.Keys)
                comboBox1.Items.Add(film);

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            richTextBox1.ReadOnly = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem == null) return;

            string film = comboBox1.SelectedItem.ToString();

            if (Data.filmData.ContainsKey(film))
                comboBox2.Items.AddRange(Data.filmData[film].Theaters.ToArray());

            ResetSeatColors();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string film = comboBox1.SelectedItem?.ToString();
            string theater = comboBox2.SelectedItem?.ToString();

            ResetSeatColors();

            if (film != null && theater != null)
                InitSeatColors(film, theater);
        }

        void ResetSeatColors()
        {
            foreach (Control ctrl in panel1.Controls)
                if (ctrl is Button btn)
                    btn.BackColor = Color.White;
        }

        void InitSeatColors(string film, string theater)
        {
            if (!Data.bookedSeats.ContainsKey(film)) return;
            if (!Data.bookedSeats[film].ContainsKey(theater)) return;

            var used = Data.bookedSeats[film][theater];

            foreach (Control ctrl in panel1.Controls)
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

            string film = comboBox1.SelectedItem?.ToString();
            string theater = comboBox2.SelectedItem?.ToString();

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
                var lines = richTextBox1.Lines.ToList();
                int lineToRemove = lines.FindIndex(line => line.StartsWith(searchString));
                if (lineToRemove >= 0)
                {
                    lines.RemoveAt(lineToRemove);
                    richTextBox1.Lines = lines.ToArray(); 
                }
            }
            else
            {
                Data.choosingSeat.Add((film, theater, seat));
                var filmInfo = Data.filmData[film];
                btn.BackColor = Color.Green;
                decimal price = Data.CalculatePrice(filmInfo.BasePrice, seat);
                richTextBox1.AppendText($"{searchString} | Giá: {price} \n");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người đặt vé!", "Lỗi");
                return;
            }
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
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
                totalPrice += Data.CalculatePrice(filmInfo.BasePrice,seat.Seat);
            }
            Data.choosingSeat.Clear();
            MessageBox.Show($"{textBox1.Text} đã đặt vé thành công!\nTổng tiền: {totalPrice}đ","Thông báo");

            ResetSeatColors();
            InitSeatColors(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
            richTextBox1.Clear();
            textBox1.Clear();
        }
    }
}
