using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab2_Bai2 : Form
    {
        public Lab2_Bai2()
        {
            InitializeComponent();
        }

        private int WordCount (String S)
        {
            int count = 0;
            count = S.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;



            return count;

        }
        private void DocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ChoChonFile = new OpenFileDialog();
            ChoChonFile.Multiselect = false;
            ChoChonFile.Filter = "Text file (*.txt)|*.txt";

            string name, url;
   
             int linecount = 0 , wordcount = 0, charcount = 0;

            if (ChoChonFile.ShowDialog() == DialogResult.OK)
            {


                try
                {
                    string Path = ChoChonFile.FileName;
                    using (StreamReader Stream = new StreamReader(Path))
                    {
                        BangNoiDung.Text = Stream.ReadToEnd();
                        name = ChoChonFile.SafeFileName.ToString();
                        url = Path;
                        linecount = BangNoiDung.Lines.Length;
                        wordcount = WordCount(BangNoiDung.Text);
                        charcount = BangNoiDung.Text.Length;
                        byte[] data = Encoding.UTF8.GetBytes(BangNoiDung.Text);

                        string bytes = data.Length + " bytes";
                        FileName.Text = name;
                        URL.Text = url;
                        Size.Text = bytes;
                        LineCount.Text = linecount.ToString();
                        WordsCount.Text = wordcount.ToString();
                        CharacterCount.Text = charcount.ToString();





                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Lỗi Đọc File: {ex.Message}");
                }
            }
           
        }

            
 

        private void BangNoiDung_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
