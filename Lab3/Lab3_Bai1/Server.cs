using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Server : Form
    {

        // - udpServer: dùng để nhận dữ liệu UDP từ client gửi tới
        // - listenThread: luồng riêng (background thread) để lắng nghe dữ liệu mà không làm treo giao diện
        UdpClient udpServer;
        Thread listenThread;

        public Server()
        {
            InitializeComponent();
        }


        private void NutListen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SoPortListen.Text))
            {
                MessageBox.Show("Vui Long Nhập Số Port");
            }

            // Chuyển port từ string sang int an toàn
            if (!int.TryParse(SoPortListen.Text.Trim(), out int port))
            {
                MessageBox.Show("Port không hợp lệ! Vui lòng nhập số nguyên từ 1 đến 65535.");
                return;
            }
            try
            {
                // Lấy số port mà người dùng nhập vào TextBox
                int Soport = int.Parse(SoPortListen.Text);

                // Tạo UDP server lắng nghe trên port đó
                udpServer = new UdpClient(Soport);

                // Nếu ListView chưa có cột thì thêm 1 cột hiển thị nội dung
                if (ListListen.Columns.Count == 0)
                    ListListen.Columns.Add("Received messages", 450);


                AddMessage($"Server is listening on port {Soport}...");

                // Khởi tạo một luồng (thread) mới để lắng nghe dữ liệu
                // => giúp chương trình không bị "treo" UI khi đang nhận liên tục
                listenThread = new Thread(() => ListenForMessages(Soport));
                listenThread.IsBackground = true;  // tự động dừng khi form đóng
                listenThread.Start();               // bắt đầu chạy luồng
            }
            catch (Exception ex)
            {

                AddMessage("Lỗi khi khởi động server: " + ex.Message);
            }
        }

        // Hàm chạy trong luồng riêng để lắng nghe tin nhắn từ client gửi tới
        private void ListenForMessages(int port)
        {
            try
            {
                // Lắng nghe tất cả các địa chỉ IP (IPAddress.Any)
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

                while (true)
                {
                    // Nhận dữ liệu từ client gửi tới
                    byte[] receiveBytes = udpServer.Receive(ref remoteEP);

                    // Giải mã bytes thành chuỗi UTF-8
                    string message = Encoding.UTF8.GetString(receiveBytes);


                    string display = $"{remoteEP.Address}:{remoteEP.Port} → {message}";

 
                    AddMessage(display);
                }
            }
            catch (Exception ex)
            {

                AddMessage("Lỗi khi nhận dữ liệu: " + ex.Message);
            }
        }

        //  Hàm an toàn để cập nhật giao diện từ luồng phụ
        // Nếu đang ở luồng khác => phải dùng Invoke() để yêu cầu UI thread thực hiện
        private void AddMessage(string mess)
        {
            if (ListListen.InvokeRequired)
            {
                // Nếu đang ở luồng phụ (thread khác UI)
                ListListen.Invoke(new Action(() =>
                {
                    ListListen.Items.Add(new ListViewItem(mess));  // thêm dòng mới vào ListView
                }));
            }
            else
            {
                // Nếu đang ở đúng luồng giao diện
                ListListen.Items.Add(new ListViewItem(mess));
            }
        }


        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            udpServer?.Close();     // đóng kết nối UDP
            listenThread?.Abort();  // dừng luồng lắng nghe
        }
    }
}
