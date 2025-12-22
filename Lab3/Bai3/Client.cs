using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private async void Send_Click(object sender, EventArgs e)
        {
            try
            {
                string serverIP = SoIP.Text.Trim();
                string message = BangTinNhan.Text.Trim();

                if (string.IsNullOrWhiteSpace(serverIP))
                    serverIP = "127.0.0.1";  // mặc định localhost

                if (!IPAddress.TryParse(serverIP, out IPAddress ipAddr))
                {
                    MessageBox.Show("IP không hợp lệ! Vui lòng nhập IP đúng dạng (ví dụ: 127.0.0.1)");
                    return;
                }

                if (!int.TryParse(SoPort.Text.Trim(), out int serverPort) || serverPort < 1 || serverPort > 65535)
                {
                    MessageBox.Show("Port không hợp lệ! (1–65535)");
                    return;
                }

                if (string.IsNullOrWhiteSpace(message))
                {
                    MessageBox.Show("Vui lòng nhập nội dung tin nhắn!");
                    return;
                }

                // Tạo client TCP
                using (TcpClient tcpClient = new TcpClient())
                {
                    // Kết nối tới server
                    await tcpClient.ConnectAsync(ipAddr, serverPort);

                    // Lấy stream để gửi dữ liệu
                    NetworkStream stream = tcpClient.GetStream();
                    byte[] sendBytes = Encoding.UTF8.GetBytes(message);

                    // Gửi tin nhắn
                    await stream.WriteAsync(sendBytes, 0, sendBytes.Length);

                    stream.Close();
                    tcpClient.Close();
                }

                MessageBox.Show("Đã gửi tin nhắn đến server!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Port không hợp lệ! Vui lòng nhập số nguyên.");
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Lỗi kết nối tới server: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi tin: " + ex.Message);
            }
        }
    }
}
