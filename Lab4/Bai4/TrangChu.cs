using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bai4.Data;

namespace Bai4
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void CreateFlowLayoutPanel()
        {
            typeof(FlowLayoutPanel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, DanhSachPhim, new object[] { true });

            this.Controls.Add(DanhSachPhim);
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            CreateFlowLayoutPanel();

            await Data.LoadFilmData();
            await DisplayFilmsDynamic(Data.filmData);
        }

        private async Task DisplayFilmsDynamic(Dictionary<string, FilmInfo> filmData)
        {
            DanhSachPhim.Controls.Clear();

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd(
                    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36"
                );

                foreach (var kv in filmData)
                {
                    var film = kv.Value;
                    Panel card = new Panel
                    {
                        Width = 180,
                        Height = 310,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(50,50,10,10),
                        BackColor = Color.WhiteSmoke
                    };

                    PictureBox pic = new PictureBox
                    {
                        Width = 160,
                        Height = 200,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = new Point(10, 10)
                    };

                    if (!string.IsNullOrEmpty(film.PosterUrl))
                    {
                        
                        try
                        {
                            var bytes = await client.GetByteArrayAsync(film.PosterUrl);

                            using (var ms = new MemoryStream(bytes))
                            {
                                Image img = Image.FromStream(ms);
                                pic.Image = new Bitmap(img);
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Lỗi tải poster {film.Name}: {ex.Message}");
                            pic.Image = null;
                        }
                    }

                    Label lbl = new Label
                    {
                        Text = film.Name,
                        Width = 160,
                        Height = 40,
                        Location = new Point(10, 215),
                        Font = new Font("Segoe UI", 9, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    Button btnUrl = new Button
                    {
                        Text = "Xem chi tiết",
                        Width = 160,
                        Height = 35,
                        Location = new Point(10, 260)
                    };
                    btnUrl.Click += (s, e) =>
                    {
                        if (!string.IsNullOrEmpty(film.DetailUrl))
                            Process.Start(new ProcessStartInfo { FileName = film.DetailUrl, UseShellExecute = true });
                    };

                    card.Click += (s, e) => ShowFilmDetail(film);
                    pic.Click += (s, e) => ShowFilmDetail(film);
                    lbl.Click += (s, e) => ShowFilmDetail(film);

                    card.Controls.Add(pic);
                    card.Controls.Add(lbl);
                    card.Controls.Add(btnUrl);

                    DanhSachPhim.Controls.Add(card);
                }
            }
        }


        private void ShowFilmDetail(FilmInfo film)
        {
            string info =
                $"Tên phim: {film.Name}\n" +
                $"Giá vé cơ bản: {film.BasePrice:N0} VNĐ\n" +
                $"Rạp chiếu: {string.Join(", ", film.Theaters)}\n" +
                $"Chi tiết: {film.DetailUrl}";

            MessageBox.Show(info, "Thông tin phim");
        }
        private void DatVe_Click(object sender, EventArgs e)
        {
            FormDatVe form2 = new FormDatVe();
            form2.Show();
            this.Hide();
        }
    }
}
