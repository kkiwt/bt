using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Bai1_Lab4 : Form
    {
        public Bai1_Lab4()
        {
            InitializeComponent();
        }

        private string getHTML(string szUrl)
        {
            WebRequest request = WebRequest.Create(szUrl); 
            WebResponse response = request.GetResponse(); 

            Stream dataStream = response.GetResponseStream(); 
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd(); 

            response.Close(); 
            return responseFromServer; 
        }

        private void Get_Click(object sender, EventArgs e)
        {
            string WebHTML = "";
            WebHTML = getHTML(URL.Text);
            NoiDung.Text = WebHTML;
        }
    }
}
