using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatServer;

namespace ChatClient
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void NutClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void Server_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }
    }
}
