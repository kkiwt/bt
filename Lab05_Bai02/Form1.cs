using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap; // thu vien IMAP
using MailKit.Net.Pop3; //thu vien POP
using MailKit.Security;
using MimeKit;

namespace Lab05_Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int EmailLimit = 10;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Email và mật khẩu.", "Thiếu thông tin", MessageBoxButtons.OK);
                return;
            }

            if (cbLogin.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giao thức (IMAP hoặc POP3).", "Thiếu lựa chọn", MessageBoxButtons.OK);
                return;
            }

            string protocol = cbLogin.SelectedItem.ToString();
            listViewEmail.Items.Clear();

            if (protocol == "IMAP")
            {
                ReadMailIMAP(username, password);
            }
            else if (protocol == "POP3")
            {
                ReadMailPOP3(username, password);
            }
        }

        private void ReadMailIMAP(string username, string password)
        {
            const string server = "imap.gmail.com";
            const int port = 993;

            try
            {
                using (var client = new ImapClient())
                {
                    client.Connect(server, port, true); 
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(username, password);

                    var inbox = client.Inbox;
                    inbox.Open(MailKit.FolderAccess.ReadOnly);

                    
                    lblTotal.Text = inbox.Count.ToString();
                    lblRecent.Text = inbox.Recent.ToString();

                    int totalEmails = inbox.Count;
                    int startIndex = Math.Max(0, totalEmails - EmailLimit);

                    for (int i = startIndex; i < totalEmails; i++)
                    {
                        var message = inbox.GetMessage(i);

                        var item = new ListViewItem(message.Subject);
                        item.SubItems.Add(message.From.ToString());
                        item.SubItems.Add(message.Date.ToString("dd/MM/yyyy HH:mm:ss"));
                        listViewEmail.Items.Add(item);
                    }

                    client.Disconnect(true);
                }
            }
            catch (AuthenticationException)
            {
                MessageBox.Show("IMAP: Xác thực thất bại. Kiểm tra Email/Mật khẩu Ứng dụng.", "Lỗi Đăng Nhập", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"IMAP: Lỗi kết nối hoặc tải mail: {ex.Message}", "Lỗi IMAP", MessageBoxButtons.OK);
            }
        }

        private void ReadMailPOP3(string username, string password)
        {
            const string server = "pop.gmail.com";
            const int port = 995;

            try
            {
                using (var client = new Pop3Client())
                {
                    client.Connect(server, port, true); 
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(username, password);

    
                    int totalEmails = client.Count;
                    lblTotal.Text = totalEmails.ToString();
                    lblRecent.Text = "0"; 

                    int startIndex = Math.Max(0, totalEmails - EmailLimit);

                    for (int i = startIndex; i < totalEmails; i++)
                    {
                        var message = client.GetMessage(i);

                        var item = new ListViewItem(message.Subject);
                        item.SubItems.Add(message.From.ToString());
                        item.SubItems.Add(message.Date.ToString("dd/MM/yyyy HH:mm:ss"));
                        listViewEmail.Items.Add(item);
                    }

                    client.Disconnect(true);
                }
            }
            catch (AuthenticationException)
            {
                MessageBox.Show("POP3: Xác thực thất bại. Kiểm tra Email/Mật khẩu Ứng dụng.", "Lỗi Đăng Nhập", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"POP3: Lỗi kết nối hoặc tải mail: {ex.Message}", "Lỗi POP3", MessageBoxButtons.OK);
            }
        }
    }
}
