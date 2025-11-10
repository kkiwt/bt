namespace Bai1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void NutServer_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }

        private void NutClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }
    }
}
