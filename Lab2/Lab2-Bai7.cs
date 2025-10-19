using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab2_Bai7 : Form
    {
        public Lab2_Bai7()
        {
            InitializeComponent();
            // Trong InitializeComponent()
            this.Load += new System.EventHandler(this.Lab2_Bai7_Load);

            // Gắn sự kiện cho TreeView
            this.treeViewFolders.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewFolders_BeforeExpand);
            this.treeViewFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFolders_AfterSelect);
        }


        private void treeViewFolders_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode currentFolderNode = e.Node;
            currentFolderNode.Nodes.Clear(); // Xóa node "giả" (...)

            try
            {
                string path = currentFolderNode.Tag.ToString();
                DirectoryInfo dir = new DirectoryInfo(path);

                // Nạp các Thư mục con
                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    // Bỏ qua thư mục hệ thống hoặc bị từ chối truy cập
                    if ((subDir.Attributes & FileAttributes.Hidden) == 0 && (subDir.Attributes & FileAttributes.System) == 0)
                    {
                        TreeNode subDirNode = new TreeNode(subDir.Name);
                        subDirNode.Tag = subDir.FullName;
                        subDirNode.Nodes.Add("..."); // Thêm node "giả" cho thư mục con
                        currentFolderNode.Nodes.Add(subDirNode);
                    }
                }

                // Nạp các File vào cùng node cha
                foreach (FileInfo file in dir.GetFiles())
                {
                    TreeNode fileNode = new TreeNode(file.Name);
                    fileNode.Tag = file.FullName; // Lưu đường dẫn file
                    currentFolderNode.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException)
            {
                currentFolderNode.Nodes.Add("Truy cập bị từ chối");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void treeViewFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // 1. Dọn dẹp Panel và kiểm tra node
            panelContent.Controls.Clear();
            if (e.Node.Tag == null) return;

            string path = e.Node.Tag.ToString();

            if (File.Exists(path)) // Nếu là FILE
            {
                string extension = Path.GetExtension(path).ToLower();

                // Xử lý FILE HÌNH ẢNH (.jpg, .png, .bmp,...)
                if (extension == ".jpg" || extension == ".png" || extension == ".bmp" || extension == ".gif")
                {
                    try
                    {
                        PictureBox pb = new PictureBox();
                        // Dùng FileStream để tránh khóa file ảnh
                        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                        {
                            pb.Image = Image.FromStream(fs);
                        }
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Dock = DockStyle.Fill;
                        panelContent.Controls.Add(pb);
                    }
                    catch (Exception)
                    {
                        DisplayMessage("Không thể tải hoặc hiển thị ảnh.", Color.Red);
                    }
                }
                // Xử lý FILE VĂN BẢN
                else if (extension == ".txt" || extension == ".log" || extension == ".cs" || extension == ".html" || extension == ".xml")
                {
                    try
                    {
                        RichTextBox rtb = new RichTextBox();
                        rtb.ReadOnly = true;
                        rtb.Text = File.ReadAllText(path);
                        rtb.Dock = DockStyle.Fill;
                        panelContent.Controls.Add(rtb);
                    }

                    catch (Exception)
                    {
                        DisplayMessage("Không thể đọc nội dung file văn bản.", Color.Red);
                    }
                }
                //  Không hỗ trọ các loại file khác
                else
                {
                    DisplayMessage($"File '{Path.GetFileName(path)}' ({extension}) không hỗ trợ xem trước.", Color.Gray);
                }
            }
            else if (Directory.Exists(path)) // Nếu là THƯ MỤC
            {
                DisplayMessage($"Đã chọn thư mục: {path}", Color.Black);
            }
        }

        // Phương thức hỗ trợ hiển thị thông báo trong panel
        private void DisplayMessage(string message, Color color)
        {
            Label lbl = new Label();
            lbl.Text = message;
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.ForeColor = color;
            panelContent.Controls.Add(lbl);
        }
        private void Lab2_Bai7_Load(object sender, EventArgs e)
        {

            // Lấy danh sách ổ đĩa
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady)
                {
                    TreeNode driveNode = new TreeNode(d.Name);
                    driveNode.Tag = d.RootDirectory.FullName; // Lưu đường dẫn
                    driveNode.Nodes.Add("..."); // Thêm node giả để có thể mở rộng
                    treeViewFolders.Nodes.Add(driveNode);
                }
            }

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
