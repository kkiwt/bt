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
            WebRequest request = WebRequest.Create(szUrl); //Tao yeu cau den URL
            WebResponse response = request.GetResponse(); //Nhan phan hoi

            Stream dataStream = response.GetResponseStream(); //Don nhan Stream
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd(); //Doc toan bo ndung tu Stream

            response.Close(); //Dong phan hoi
            return responseFromServer; //tra ve ndung tu sv
        }

        private void Get_Click(object sender, EventArgs e)
        {
            string WebHTML = "";
            WebHTML = getHTML(URL.Text);
            NoiDung.Text = WebHTML;
        }
    }
}
