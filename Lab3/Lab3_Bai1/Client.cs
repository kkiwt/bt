using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
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

                int serverPort = int.Parse(SoPort.Text.Trim());

                // Nếu người dùng không nhập IP, tự động dùng localhost (127.0.0.1)
                if (string.IsNullOrWhiteSpace(serverIP))
                {
                    serverIP = "127.0.0.1";
                }



                if (!IPAddress.TryParse(serverIP, out IPAddress ipAddr))
                {
                    MessageBox.Show("IP không hợp lệ! Vui lòng nhập IP đúng dạng, ví dụ 127.0.0.1");
                    return;
                }

                string message = BangTinNhan.Text.Trim();


                if (string.IsNullOrWhiteSpace(message))
                {
                    MessageBox.Show("Vui lòng nhập nội dung tin nhắn!");
                    return;
                }
                byte[] sendBytes = Encoding.UTF8.GetBytes(message);

                // Sử dụng UdpClient để gửi dữ liệu
                // using đảm bảo udpClient sẽ tự động đóng và giải phóng tài nguyên sau khi xong
                using (UdpClient udpClient = new UdpClient())
                {
                    // SendAsync gửi dữ liệu qua UDP một cách bất đồng bộ (asynchronous)
                    await udpClient.SendAsync(sendBytes, sendBytes.Length, serverIP, serverPort);

                    // Khi gửi xong, chương trình sẽ tiếp tục chạy các dòng phía dưới await

                }

                MessageBox.Show("Đã gửi tin nhắn!");
            }
            catch (FormatException)
            {

                MessageBox.Show("Port không hợp lệ! Vui lòng nhập số nguyên.");
            }
            catch (SocketException ex)
            {
                // Xử lý lỗi khi không thể kết nối tới server (IP/Port sai hoặc server offline)
                MessageBox.Show("Lỗi kết nối tới server: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Bắt tất cả các lỗi khác (ví dụ: lỗi mạng, lỗi hệ thống...)
                MessageBox.Show("Lỗi khi gửi tin: " + ex.Message);
            }
        }
    }
}
