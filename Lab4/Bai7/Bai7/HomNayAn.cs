using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class HomNayAn : Form
    {
        public HomNayAn()
        {
            InitializeComponent();
        }

        public HomNayAn(string tenMon, string gia, string diaChi, string nguoiDongGop, string hinhAnhUrl)
        {
            InitializeComponent();
            TenMonAn.Text = tenMon;
            GiaLabel.Text = $"Giá: {gia} VND";
            DiaChiLabel.Text = $"Địa chỉ: {diaChi}";
            NguoiDongGopLabel.Text = $"Người đóng góp: {nguoiDongGop}";

            try
            {
                AnhThucAn.SizeMode = PictureBoxSizeMode.StretchImage;
                AnhThucAn.Load(hinhAnhUrl);
            }
            catch
            {
                AnhThucAn.Image = null; // hoặc ảnh mặc định
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
