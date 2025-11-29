using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Bai_6
{
    public partial class Bai_6 : Form
    {
        public Bai_6()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            string url = "https://nt106.uitiot.vn/api/v1/user/me";
            string accessToken = textBoxToken.Text;

            if (string.IsNullOrWhiteSpace(accessToken))
            {
                MessageBox.Show("Vui lòng nhập Token (lấy từ bài 5)!");
                return;
            }

            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                    HttpResponseMessage response = await client.GetAsync(url);

                    string responseContent = await response.Content.ReadAsStringAsync();

                    JObject jsonFormatted = JObject.Parse(responseContent);
                    rtbResult.Text = jsonFormatted.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

        }
    }
}
