
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bai7
{
    public partial class MonAnGmail : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MonAnId { get; set; } 

        public MonAnGmail()
        {
            InitializeComponent();
        }

        public void SetData(string id, string tenMon, string gia, string diaChi, string nguoiDongGop, string hinhAnhUrl, bool showDeleteButton)
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
            if (string.IsNullOrWhiteSpace(MonAnId))
            {
                MessageBox.Show("Không có ID để xóa.");
                return;
            }

            var confirm = MessageBox.Show(
                "Bạn chắc chắn muốn xóa món ăn này khỏi cơ sở dữ liệu?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            var parentForm = this.FindForm() as TrangChu;
            if (parentForm == null)
            {
                MessageBox.Show("Không tìm thấy form cha để thực hiện xóa.");
                return;
            }


            bool ok = await parentForm.DeleteMonAnRpcAsync(MonAnId);

            if (ok)
            {

                var container = this.Parent;
                this.Dispose();
                container?.Refresh();
            }
        }


    }
}

