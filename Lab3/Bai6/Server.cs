using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Server : Form
    {
        private delegate void UpdateStatusCallback(string strMessage, string fileType = null, byte[] fileData = null, string fileName = null, string fromUser = null);
        private ChatServer mainServer;

        public Server()
        {
            InitializeComponent();
            flpLog.FlowDirection = FlowDirection.TopDown;
            flpLog.WrapContents = false;
            flpLog.AutoScroll = true;
        }



        private void btnListen_Click(object sender, EventArgs e)
        {
            try
            {

                this.mainServer = new ChatServer(IPAddress.Any);

                ChatServer.StatusChanged += new StatusChangedEventHandler(mainServer_StatusChanged);
                this.mainServer.StartListening();
                UpdateStatus("Server đang theo dõi các kết nối...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void mainServer_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            // Kiểm tra xem có phải gửi file không
            // Cú pháp: nếu EventMessage bắt đầu bằng "FILECONTENT|from|filename|filetype|base64"
            if (e.EventMessage.StartsWith("FILECONTENT|"))
            {
                string[] parts = e.EventMessage.Split(new char[] { '|' }, 5);
                if (parts.Length == 5)
                {
                    string from = parts[1];
                    string fileName = parts[2];
                    string fileType = parts[3];
                    byte[] raw = Convert.FromBase64String(parts[4]);

                    this.Invoke(new Action(() =>
                    {
                        if (fileType == "TEXT")
                        {
                            Label lbl = new Label();
                            lbl.Text = $"{from} gửi file: {fileName} ({fileType}, {raw.Length} bytes)";
                            lbl.AutoSize = false;
                            lbl.Width = flpLog.ClientSize.Width - 25;
                            flpLog.Controls.Add(lbl);
                        }
                        else if (fileType == "IMAGE")
                        {
                            Label lbl = new Label();
                            lbl.Text = $"{from} gửi ảnh: {fileName} ({fileType}, {raw.Length} bytes)";
                            lbl.AutoSize = false;
                            lbl.Width = flpLog.ClientSize.Width - 25;
                            flpLog.Controls.Add(lbl);
                        }

                        flpLog.ScrollControlIntoView(flpLog.Controls[flpLog.Controls.Count - 1]);
                    }));
                }
                return;
            }



            // Bình thường chỉ log message text
            this.Invoke(new UpdateStatusCallback(this.UpdateStatus), new object[] { e.EventMessage, null, null, null, null });
        }

        private void UpdateStatus(string strMessage, string fileType = null, byte[] fileData = null, string fileName = null, string fromUser = null)
        {
            if (!string.IsNullOrEmpty(strMessage))
            {
                Label lbl = new Label();
                lbl.Text = strMessage;
                lbl.AutoSize = false;
                lbl.Width = flpLog.ClientSize.Width - 25;
                flpLog.Controls.Add(lbl);
                flpLog.ScrollControlIntoView(lbl);
            }

            if (fileData != null && !string.IsNullOrEmpty(fileType))
            {
                if (fileType == "TEXT")
                {
                    Label lblHeader = new Label();
                    lblHeader.Text = $"{fromUser} gửi file: {fileName} ({fileType}, {fileData?.Length ?? 0} bytes)";
                    lblHeader.Font = new Font(lblHeader.Font, FontStyle.Bold);
                    lblHeader.AutoSize = false;
                    lblHeader.Width = flpLog.ClientSize.Width - 25;

                    flpLog.Controls.Add(lblHeader);
                    flpLog.ScrollControlIntoView(lblHeader);
                }
                else if (fileType == "IMAGE")
                {
                    Label lbl = new Label();
                    lbl.Text = $"{fromUser} gửi ảnh: {fileName} ({fileType}, {fileData?.Length ?? 0} bytes)";
                    lbl.Font = new Font(lbl.Font, FontStyle.Bold);
                    lbl.AutoSize = false;
                    lbl.Width = flpLog.ClientSize.Width - 25;

                    flpLog.Controls.Add(lbl);
                    flpLog.ScrollControlIntoView(lbl);
                }
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                ChatServer.SendAdminMessage("Máy chủ đang tắt.");
                ChatServer.Shutdown(); 
            }
            catch { }

            base.OnFormClosing(e);
        }

        private void NutTatListen_Click(object sender, EventArgs e)
        {
            try
            {
                ChatServer.SendAdminMessage("Máy chủ đang tắt.");
                ChatServer.Shutdown();
                ChatServer.StatusChanged -= new StatusChangedEventHandler(mainServer_StatusChanged);
                this.mainServer = null; // reset để có thể Start lại
            }
            catch { }
        }
    }
}
