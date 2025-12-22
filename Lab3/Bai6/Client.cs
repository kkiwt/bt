using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class Client : Form
    {
        private string UserName = "Unknown";
        private StreamWriter swSender;
        private StreamReader srReceiver;
        private TcpClient tcpServer;
        private IPAddress ipAddr;
        private Thread thrMessaging;
        private bool Connected;
        private bool requestedDisconnect = false;

        private delegate void UpdateLogCallback(string strMessage);
        private delegate void CloseConnectionCallback(string strReason);

        public Client()
        {
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            InitializeComponent();

            if (this.cbbParticipants.Items.Count == 0)
                this.cbbParticipants.Items.Add("All");
            this.cbbParticipants.SelectedIndex = 0;

            txtMessage.Enabled = false;
            btnSend.Enabled = false;

            // FlowLayoutPanel chat
            flpChat.AutoScroll = true;
            flpChat.FlowDirection = FlowDirection.TopDown;
            flpChat.WrapContents = false;
        }

        // Ngắt kết nối khi đóng app
        private void OnApplicationExit(object sender, EventArgs e)
        {
            if (Connected)
            {
                Connected = false;
                swSender?.Close();
                srReceiver?.Close();
                tcpServer?.Close();
            }
        }

        // Nút Connect/Disconnect
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!Connected)
            {
                // Validate: bắt buộc phải nhập tên trước khi kết nối
                string user = txtUser.Text?.Trim();
                if (string.IsNullOrEmpty(user))
                {
                    MessageBox.Show("Bạn phải nhập tên trước khi kết nối.", "Thiếu tên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Focus();
                    return;
                }

                InitializeConnection();
            }
            else
            {
                requestedDisconnect = true;
                CloseConnection("Bạn đã thoát.");
            }
        }

        private void InitializeConnection()
        {
            try
            {
                ipAddr = IPAddress.Parse(txtIp.Text);
                tcpServer = new TcpClient();
                tcpServer.Connect(ipAddr, 2006);
                Connected = true;

                UserName = txtUser.Text;

                txtIp.Enabled = false;
                txtUser.Enabled = false;
                txtMessage.Enabled = true;
                btnSend.Enabled = true;
                btnConnect.Text = "Disconnect";

                swSender = new StreamWriter(tcpServer.GetStream());
                swSender.WriteLine(UserName);
                swSender.Flush();

                thrMessaging = new Thread(new ThreadStart(ReceiveMessages));
                thrMessaging.Start();
            }
            catch (Exception ex)
            {
                UpdateLog("Lỗi kết nối: " + ex.Message);
            }
        }

        private void SafeInvoke(Action action)
        {
            if (this.IsHandleCreated)
                this.Invoke(action);
            else
                action();
        }

        private void ReceiveMessages()
        {
            try
            {
                srReceiver = new StreamReader(tcpServer.GetStream());
                string ConResponse = srReceiver.ReadLine();

                if (ConResponse == null) { CloseConnection("Server đóng kết nối."); return; }

                if (ConResponse[0] == '1')
                    SafeInvoke(() => AddSystemMessage("Kết nối thành công tới server."));
                else
                {
                    string Reason = "Không thể kết nối: " + ConResponse.Substring(2);
                    SafeInvoke(() => CloseConnection(Reason));
                    return;
                }

                while (Connected)
                {
                    string line = srReceiver.ReadLine();
                    if (line != null && line.StartsWith("SERVER_SHUTDOWN|"))
                    {
                        SafeInvoke(() => CloseConnection("Server đã tắt."));
                        break;
                    }
                    if (line == null) break;

                    if (line.StartsWith("FILECONTENT|"))
                    {
                        string[] parts = line.Split(new char[] { '|' }, 5);
                        if (parts.Length == 5)
                        {
                            string from = parts[1];
                            string fileName = parts[2];
                            string fileType = parts[3];
                            string base64 = parts[4];

                            byte[] raw = Convert.FromBase64String(base64);

                            SafeInvoke(() =>
                            {
                                if (fileType == "TEXT")
                                {
                                    string text = Encoding.UTF8.GetString(raw);

                                    string headerFrom = $"{from} (gửi riêng cho bạn)";
                                    AddFileTextMessage(headerFrom, fileName, text);
                                }
                                else if (fileType == "IMAGE")
                                {
                                    using (MemoryStream ms = new MemoryStream(raw))
                                    {
                                        PictureBox pb = new PictureBox();
                                        pb.Image = System.Drawing.Image.FromStream(ms);
                                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                                        pb.BorderStyle = BorderStyle.FixedSingle;

                                        Label lbl = new Label();
                                        lbl.Text = $"{from} (gửi riêng cho bạn) gửi ảnh: {fileName}";
                                        lbl.AutoSize = true;

                                        FlowLayoutPanel panel = new FlowLayoutPanel();
                                        panel.FlowDirection = FlowDirection.TopDown;
                                        panel.AutoSize = true;
                                        panel.Controls.Add(lbl);
                                        panel.Controls.Add(pb);

                                        flpChat.Controls.Add(panel);
                                        flpChat.ScrollControlIntoView(panel);
                                    }
                                }
                            });
                        }
                    }
                    else if (line.StartsWith("USERLIST|"))
                    {
                        string usersCsv = line.Substring("USERLIST|".Length);
                        string[] users = usersCsv.Split(',');

                        SafeInvoke(() =>
                        {
                            cbbParticipants.Items.Clear();
                            cbbParticipants.Items.Add("All");
                            foreach (string u in users)
                                if (u != UserName) cbbParticipants.Items.Add(u);
                            cbbParticipants.SelectedIndex = 0;
                        });
                    }
                    else
                    {
                        SafeInvoke(() => AddChatMessage(line));
                    }
                }

                SafeInvoke(() => CloseConnection("Server đã ngắt kết nối."));
            }
            catch (Exception ex)
            {
                if (requestedDisconnect)
                {
                    requestedDisconnect = false;
                    return;
                }

                SafeInvoke(() => CloseConnection("Lỗi nhận dữ liệu: " + ex.Message));
            }
        }

        private void UpdateLog(string strMessage)
        {
            MessageBox.Show(strMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool isClosing = false;
        private void CloseConnection(string Reason)
        {
            if (isClosing) return;
            isClosing = true;

            try
            {
                if (Connected && swSender != null)
                {
                    swSender.WriteLine("/exit");
                    swSender.Flush();
                }
            }
            catch { }

            if (!this.IsDisposed && flpChat != null && !flpChat.IsDisposed)
            {
                if (this.InvokeRequired)
                    this.Invoke(new Action(() => AddSystemMessage(Reason)));
                else
                    AddSystemMessage(Reason);
            }

            txtIp.Enabled = true;
            txtUser.Enabled = true;
            txtMessage.Enabled = false;
            btnSend.Enabled = false;
            btnConnect.Text = "Connect";

            Connected = false;

            try { swSender?.Close(); } catch { }
            try { srReceiver?.Close(); } catch { }
            try { tcpServer?.Close(); } catch { }

            isClosing = false;
        }

        private void SendMessage()
        {
            if (!Connected) return;
            string msg = txtMessage.Text.Trim();
            if (string.IsNullOrEmpty(msg)) return;

            string recipient = cbbParticipants.SelectedItem?.ToString() ?? "All";
            if (recipient != "All")
                swSender.WriteLine($"/w {recipient} {msg}");
            else
                swSender.WriteLine(msg);

            swSender.Flush();
            txtMessage.Clear();

            txtMessage.Focus();
            txtMessage.SelectionStart = txtMessage.Text.Length;
        }

        private void btnSend_Click(object sender, EventArgs e) => SendMessage();

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) SendMessage();
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            if (!Connected || tcpServer == null || swSender == null)
            {
                UpdateLog("Phải kết nối trước khi gửi file!");
                return;
            }

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn file cần gửi";
                ofd.Filter = "Text files (*.txt;*.json;*.xml)|*.txt;*.json;*.xml|" +
                             "Images (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|" +
                             "All files (*.*)|*.*";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                string filePath = ofd.FileName;
                string fileName = Path.GetFileName(filePath);
                string ext = Path.GetExtension(filePath).ToLowerInvariant();

                byte[] raw;
                string fileType;

                try
                {
                    if (ext == ".txt" || ext == ".json" || ext == ".xml")
                    {
                        fileType = "TEXT";
                        string text = File.ReadAllText(filePath, Encoding.UTF8);
                        raw = Encoding.UTF8.GetBytes(text);
                    }
                    else
                    {
                        fileType = "IMAGE";
                        raw = File.ReadAllBytes(filePath);
                    }
                }
                catch (Exception ex)
                {
                    UpdateLog("Lỗi đọc file: " + ex.Message);
                    return;
                }

                string recipient = "All";
                if (cbbParticipants.SelectedItem != null)
                {
                    string sel = cbbParticipants.SelectedItem.ToString();
                    if (!string.IsNullOrWhiteSpace(sel)) recipient = sel;
                }

                try
                {
                    string base64 = Convert.ToBase64String(raw);
                    swSender.WriteLine($"FILECONTENT|{recipient}|{fileName}|{fileType}|{base64}");
                    swSender.Flush();
                    SafeInvoke(() =>
                    {
                        string headerFrom = (recipient != "All") ? $"Bạn (gửi riêng cho {recipient})" : "Bạn";

                        if (fileType == "TEXT")
                        {
                            string text = Encoding.UTF8.GetString(raw);
                            AddFileTextMessage(headerFrom, fileName, text);
                        }
                        else if (fileType == "IMAGE")
                        {
                            using (MemoryStream ms = new MemoryStream(raw))
                            {
                                PictureBox pb = new PictureBox();
                                pb.Image = System.Drawing.Image.FromStream(ms);
                                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                                pb.BorderStyle = BorderStyle.FixedSingle;

                                Label lbl = new Label();
                                lbl.Text = $"{headerFrom} gửi ảnh: {fileName}";
                                lbl.AutoSize = true;

                                FlowLayoutPanel panel = new FlowLayoutPanel();
                                panel.FlowDirection = FlowDirection.TopDown;
                                panel.AutoSize = true;
                                panel.Controls.Add(lbl);
                                panel.Controls.Add(pb);

                                flpChat.Controls.Add(panel);
                                flpChat.ScrollControlIntoView(panel);
                            }
                        }
                    });
                }
                catch (Exception ex)
                {
                    UpdateLog("Lỗi khi gửi file: " + ex.Message);
                }
            }
        }
        private void AddChatMessage(string message)
        {
            Label lbl = new Label();
            lbl.Text = message;
            lbl.AutoSize = true;
            lbl.MaximumSize = new System.Drawing.Size(flpChat.Width - 25, 0);
            flpChat.Controls.Add(lbl);
            flpChat.ScrollControlIntoView(lbl);
        }

        private void AddSystemMessage(string message)
        {
            Label lbl = new Label();
            lbl.Text = message;
            lbl.ForeColor = System.Drawing.Color.Blue;
            lbl.AutoSize = true;
            flpChat.Controls.Add(lbl);
            flpChat.ScrollControlIntoView(lbl);
        }

        private void AddFileTextMessage(string from, string fileName, string text)
        {
            Label lblHeader = new Label();
            lblHeader.Text = $"{from} gửi file: {fileName}";
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font(lblHeader.Font, System.Drawing.FontStyle.Bold);

            TextBox txtContent = new TextBox();
            txtContent.Multiline = true;
            txtContent.ReadOnly = true;
            txtContent.ScrollBars = ScrollBars.Vertical;
            txtContent.Text = text;
            txtContent.Width = flpChat.Width - 30;
            txtContent.Height = Math.Min(200, 20 * (text.Split('\n').Length + 1));

            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.FlowDirection = FlowDirection.TopDown;
            panel.AutoSize = true;
            panel.Controls.Add(lblHeader);
            panel.Controls.Add(txtContent);

            flpChat.Controls.Add(panel);
            flpChat.ScrollControlIntoView(panel);
        }
        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Đánh dấu yêu cầu disconnect để tránh hiển thị lỗi mạng
            requestedDisconnect = true;

            try
            {
                if (Connected && swSender != null)
                {
                    try
                    {
                        swSender.WriteLine("/exit");
                        swSender.Flush();
                    }
                    catch { }
                }
            }
            catch { }

            // Hiển thị thông báo trong flpChat rồi đóng kết nối local
            CloseConnection("Bạn đã thoát.");
        }
    }
}
