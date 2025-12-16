using System.Net;
using System;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Bai2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string url = txtURL.Text.Trim();
            string FilePath = txtSaveFile.Text.Trim();
            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(FilePath))

            {

                MessageBox.Show("Vui lòng nhập đầy đủ URL và đường dẫn lưu File", "Lỗi", MessageBoxButtons.OK);

                return;

            }
            if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) && !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))

            {
                url = "http://" + url;
            }

            try

            {

                using (WebClient client = new WebClient())

                {
                    client.Encoding = System.Text.Encoding.UTF8;
                    client.DownloadFile(url, FilePath);
                }

                string hmtlcontent = File.ReadAllText(FilePath);
                rtbShowContent.Text = hmtlcontent;

            }



            catch (WebException ex)
            {

                MessageBox.Show($"Lỗi Web: {ex.Message}\nvui lòng kiểm tra lại URL.", "Lỗi Tải Xuống", MessageBoxButtons.OK);
            }
            catch (IOException ex)
            {

                MessageBox.Show($"Lỗi File: {ex.Message}", "Lỗi Ghi File", MessageBoxButtons.OK);

            }

            catch (Exception ex)

            {

                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK);
            }
            Cursor = Cursors.Default;  

        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "HTMl (*.html)|*.html|Tất cả tệp (*.*)|*.*";

            saveFileDialog.FilterIndex = 1;

            saveFileDialog.RestoreDirectory = true;

            saveFileDialog.FileName = "Download.HTML"; // Mac Dinh
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                txtSaveFile.Text = saveFileDialog.FileName;

            }
        }
    }
}
