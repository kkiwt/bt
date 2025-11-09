using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatServer
{
    public class StatusChangedEventArgs : EventArgs
    {
        private string EventMsg;
        public string EventMessage { get => EventMsg; set => EventMsg = value; }

        public StatusChangedEventArgs(string strEventMsg)
        {
            EventMsg = strEventMsg;
        }
    }

    public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);

    class ChatServer
    {
        public static Hashtable htUsers = new Hashtable(30);
        public static Hashtable htConnections = new Hashtable(30);

        private IPAddress ipAddress;
        private TcpClient tcpClient;
        public static event StatusChangedEventHandler StatusChanged;
        private static StatusChangedEventArgs e;

        private Thread thrListener;
        private TcpListener tlsClient;
        bool ServRunning = false;

        public ChatServer(IPAddress address)
        {
            ipAddress = address;
        }
        // Gửi danh sách user đang online
        public static void UpdateUserList()
        {
            string users = string.Join(",", htUsers.Keys.Cast<string>());
            Broadcast("USERLIST|" + users); // client sẽ nhận và cập nhật ComboBox
        }

        public static void AddUser(TcpClient tcpUser, string strUsername)
        {
            htUsers.Add(strUsername, tcpUser);
            htConnections.Add(tcpUser, strUsername);
            SendAdminMessage($"{strUsername} đã tham gia phòng chat.");
            UpdateUserList(); // cập nhật danh sách
        }

        public static void RemoveUser(TcpClient tcpUser)
        {
            if (htConnections[tcpUser] != null)
            {
                string user = (string)htConnections[tcpUser];
                htUsers.Remove(user);
                htConnections.Remove(tcpUser);

                SendAdminMessage($"{user} đã rời khỏi phòng.");
                UpdateUserList();
            }
        }



        public static void OnStatusChanged(StatusChangedEventArgs e)
        {
            StatusChanged?.Invoke(null, e);
        }

        public static void SendAdminMessage(string Message)
        {
            e = new StatusChangedEventArgs("Server: " + Message);
            OnStatusChanged(e);

            Broadcast("Server: " + Message);
        }

        // Gửi tin nhắn đến tất cả client
        public static void Broadcast(string message)
        {
            TcpClient[] tcpClients = new TcpClient[htUsers.Count];
            htUsers.Values.CopyTo(tcpClients, 0);

            foreach (TcpClient client in tcpClients)
            {
                try
                {
                    if (client == null) continue;
                    StreamWriter swSender = new StreamWriter(client.GetStream());
                    swSender.WriteLine(message);
                    swSender.Flush();

                    // Nếu message là FILECONTENT, cũng trigger StatusChanged để server hiển thị
                    if (message.StartsWith("FILECONTENT|"))
                    {
                        OnStatusChanged(new StatusChangedEventArgs(message));
                    }
                }
                catch
                {
                    RemoveUser(client);
                }
            }
        }


        // Gửi tin nhắn riêng
        public static void SendPrivate(string from, string to, string message)
        {
            if (!htUsers.Contains(to))
            {
                SendBackToSender(from, $"Server: Người nhận '{to}' không tồn tại.");
                return;
            }

            TcpClient toClient = (TcpClient)htUsers[to];
            TcpClient fromClient = (TcpClient)htUsers[from];

            // Hiển thị rõ ràng cho người nhận là "gửi riêng cho bạn"
            StreamWriter swTo = new StreamWriter(toClient.GetStream());
            swTo.WriteLine($"{from} (gửi riêng cho bạn): {message}");
            swTo.Flush();

            // Dành cho người gửi
            StreamWriter swFrom = new StreamWriter(fromClient.GetStream());
            swFrom.WriteLine($"{from} (gửi riêng cho {to}): {message}");
            swFrom.Flush();

            OnStatusChanged(new StatusChangedEventArgs($"{from} gửi riêng cho {to}: {message}"));
        }

        private static void SendBackToSender(string from, string msg)
        {
            if (!htUsers.Contains(from)) return;
            TcpClient senderClient = (TcpClient)htUsers[from];
            StreamWriter swSender = new StreamWriter(senderClient.GetStream());
            swSender.WriteLine(msg);
            swSender.Flush();
        }

        // Gửi file tới người nhận hoặc tất cả
        public static void SendFile(string from, string recipient, string fileName, string fileType, string base64)
        {
            string header = $"FILECONTENT|{from}|{fileName}|{fileType}|{base64}";
            if (recipient == "All")
            {
                Broadcast(header); // gửi cho tất cả
            }
            else
            {
                if (htUsers.Contains(recipient))
                {
                    TcpClient toClient = (TcpClient)htUsers[recipient];
                    StreamWriter swTo = new StreamWriter(toClient.GetStream());
                    swTo.WriteLine(header);
                    swTo.Flush();
                }
            }
        }
        // Thêm phương thức shutdown để báo và đóng tất cả kết nối khi server tắt
        public static void Shutdown()
        {
            try
            {
                // Thông báo cho client rằng server sẽ tắt
                Broadcast("SERVER_SHUTDOWN|Server is closing");

                // Đóng tất cả kết nối client
                TcpClient[] tcpClients = new TcpClient[htUsers.Count];
                htUsers.Values.CopyTo(tcpClients, 0);

                foreach (TcpClient client in tcpClients)
                {
                    try
                    {
                        if (client == null) continue;
                        try { client.GetStream()?.Close(); } catch { }
                        try { client.Close(); } catch { }
                    }
                    catch { }
                }

                htUsers.Clear();
                htConnections.Clear();
            }
            catch { }
        }


        // Bắt đầu lắng nghe
        public void StartListening()
        {
            tlsClient = new TcpListener(ipAddress, 2006);
            tlsClient.Start();
            ServRunning = true;

            thrListener = new Thread(KeepListening);
            thrListener.Start();
        }

        private void KeepListening()
        {
            while (ServRunning)
            {
                tcpClient = tlsClient.AcceptTcpClient();
                Connection newConnection = new Connection(tcpClient);
            }
        }
    }

    class Connection
    {
        TcpClient tcpClient;
        private Thread thrSender;
        private StreamReader srReceiver;
        private StreamWriter swSender;
        private string currUser;
        private string strResponse;

        public Connection(TcpClient tcpCon)
        {
            tcpClient = tcpCon;
            thrSender = new Thread(AcceptClient);
            thrSender.Start();
        }

        private void CloseConnection()
        {
            tcpClient.Close();
            srReceiver.Close();
            swSender.Close();
        }

        private void AcceptClient()
        {
            srReceiver = new StreamReader(tcpClient.GetStream());
            swSender = new StreamWriter(tcpClient.GetStream());

            currUser = srReceiver.ReadLine();

            if (string.IsNullOrWhiteSpace(currUser))
            {
                CloseConnection();
                return;
            }

            if (ChatServer.htUsers.Contains(currUser))
            {
                swSender.WriteLine("0|Tên người dùng đã tồn tại.");
                swSender.Flush();
                CloseConnection();
                return;
            }
            else if (currUser == "Administrator")
            {
                swSender.WriteLine("0|Tên này được dành riêng cho hệ thống.");
                swSender.Flush();
                CloseConnection();
                return;
            }
            else
            {
                swSender.WriteLine("1");
                swSender.Flush();
                ChatServer.AddUser(tcpClient, currUser);
            }

            try
            {
                while ((strResponse = srReceiver.ReadLine()) != null)
                {
                    if (strResponse == "/exit")
                    {
                        ChatServer.RemoveUser(tcpClient); // hoặc currUser nếu dùng tên
                        break; // thoát vòng lặp
                    }
                    if (strResponse.StartsWith("/w "))
                    {
                        // Cú pháp: /w TênNgườiNhận NộiDung
                        string[] split = strResponse.Split(new char[] { ' ' }, 3);
                        if (split.Length >= 3)
                        {
                            string toUser = split[1];
                            string msg = split[2];
                            ChatServer.SendPrivate(currUser, toUser, msg);
                        }
                    }
                    else if (strResponse.StartsWith("FILECONTENT|"))
                    {
                        // FILECONTENT|recipient|filename|fileType|base64
                        string[] parts = strResponse.Split(new char[] { '|' }, 5);
                        if (parts.Length == 5)
                        {
                            string recipient = parts[1];
                            string fileName = parts[2];
                            string fileType = parts[3];
                            string base64 = parts[4];
                            ChatServer.SendFile(currUser, recipient, fileName, fileType, base64);
                        }
                    }
                    else // broadcast
                    {
                        string msg = $"{currUser}: {strResponse}";
                        ChatServer.Broadcast(msg);
                        ChatServer.OnStatusChanged(new StatusChangedEventArgs(msg));
                    }


                }
            }
            catch
            {
                ChatServer.RemoveUser(tcpClient);
                CloseConnection();
            }
        }
    }
}
