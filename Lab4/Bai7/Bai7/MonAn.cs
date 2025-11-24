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
    public partial class MonAn : UserControl
    {

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int MonAnId { get; set; }


        public MonAn()
        {
            InitializeComponent();

        }




        public void SetData(int id, string tenMon, string gia, string diaChi, string nguoiDongGop, string hinhAnhUrl, bool showDeleteButton)
        {
            MonAnId = id;
            TenMonAn.Text = tenMon;
            GiaLabel.Text = $"Giá: {gia} VND";
            DiaChiLabel.Text = $"Địa chỉ: {diaChi}";
            NguoiDongGopLabel.Text = $"Người đóng góp: {nguoiDongGop}";
            btnDelete.Visible = showDeleteButton;

            try
            {
                AnhThucAn.SizeMode = PictureBoxSizeMode.StretchImage;
                AnhThucAn.Load(hinhAnhUrl);
            }
            catch
            {
                AnhThucAn.Image = null;
            }
        }



        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm() as TrangChu;
            if (parentForm != null)
            {
                await parentForm.DeleteMonAnAsync(MonAnId);
            }
        }

    }
}
