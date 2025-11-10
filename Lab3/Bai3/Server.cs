using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Server : Form
    {
        TcpListener tcpServer;
        Thread listenThread;

        public Server()
        {
            InitializeComponent();
        }

        private void NutListen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SoPortListen.Text))
            {
                MessageBox.Show("Vui lòng nhập số port!");
                return;
            }

            if (!int.TryParse(SoPortListen.Text.Trim(), out int port) || port < 1 || port > 65535)
            {
                MessageBox.Show("Port không hợp lệ! (1–65535)");
                return;
            }

            try
            {
                tcpServer = new TcpListener(IPAddress.Any, port);
                tcpServer.Start();

                if (ListListen.Columns.Count == 0)
                    ListListen.Columns.Add("Received messages", 450);

                AddMessage($"TCP Server is listening on port {port}...");

                listenThread = new Thread(ListenForClients);
                listenThread.IsBackground = true;
                listenThread.Start();
            }
            catch (Exception ex)
            {
                AddMessage("Lỗi khi khởi động server: " + ex.Message);
            }
        }

        private void ListenForClients()
        {
            try
            {
                while (true)
                {
                    TcpClient client = tcpServer.AcceptTcpClient();
                    IPEndPoint remoteEP = (IPEndPoint)client.Client.RemoteEndPoint;
                    AddMessage($"Client connected: {remoteEP.Address}:{remoteEP.Port}");

                    // Mỗi client có 1 thread riêng để xử lý
                    Thread clientThread = new Thread(HandleClient);
                    clientThread.IsBackground = true;
                    clientThread.Start(client);
                }
            }
            catch (SocketException ex)
            {
                AddMessage("Server stopped: " + ex.Message);
            }
        }

        private void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            IPEndPoint remoteEP = (IPEndPoint)client.Client.RemoteEndPoint;

            try
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    AddMessage($"{remoteEP.Address}:{remoteEP.Port} → {message}");
                }
            }
            catch (Exception ex)
            {
                AddMessage($"Lỗi khi nhận từ {remoteEP.Address}:{remoteEP.Port}: {ex.Message}");
            }
            finally
            {
                client.Close();
                AddMessage($"Client disconnected: {remoteEP.Address}:{remoteEP.Port}");
            }
        }

        private void AddMessage(string mess)
        {
            if (ListListen.InvokeRequired)
            {
                ListListen.Invoke(new Action(() =>
                {
                    ListListen.Items.Add(new ListViewItem(mess));
                }));
            }
            else
            {
                ListListen.Items.Add(new ListViewItem(mess));
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                tcpServer?.Stop();
                listenThread?.Abort();
            }
            catch { }
        }
    }
}
