using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Bai02
{
    public partial class TCPlistener : Form
    {
        public TCPlistener()
        {
            InitializeComponent();
        }

        private void listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }

        void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1024];

            Socket clientSocket;
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080); 

            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(1);

            listen.Enabled = false;
            clientSocket = listenerSocket.Accept();
            listViewCommand.Items.Add(new ListViewItem("New Client Connected"));

            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    if (bytesReceived == 0)
                        break;
                    text += Encoding.ASCII.GetString(recv, 0, bytesReceived);
                } while (text[text.Length - 1] != '\n');

                if (!string.IsNullOrEmpty(text))
                {
                    listViewCommand.Items.Add(new ListViewItem(text.Trim()));
                }
                
                listenerSocket.Close();
            }
        }

    }
}


