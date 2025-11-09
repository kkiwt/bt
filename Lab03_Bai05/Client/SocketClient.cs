using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace Client
{
    public class SocketClient
    {
        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private const int PORT = 1111;
        private const string SERVER_IP = "127.0.0.1";
        public bool IsConnected { get; private set; } = false;

        public bool Connect()
        {
            try
            {
                client = new TcpClient();
                client.Connect(SERVER_IP, PORT);
                var stream = client.GetStream();
                reader = new StreamReader(stream, Encoding.UTF8);
                writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true };
                IsConnected = true;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Kết nối thất bại: {ex.Message}");
                IsConnected = false;
                return false;
            }
        }

        public string SendRequest(string request)
        {
            if (!IsConnected)
            {
                return "Chưa kết nối đến server.";
            }
            try
            {
                writer.WriteLine(request);
                string response = reader.ReadLine();
                return response;
            }
            catch (Exception ex)
            {
                return $"Lỗi gửi yêu cầu: {ex.Message}";
            }
        }

        public void Disconnect()
        {
            if (client != null)
            {
                reader.Close();
                writer.Close();
                client.Close();
                IsConnected = false;
            }
        }
    }
}
