namespace Lab01
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Bai1 f2 = new Bai1();
            f2.ShowDialog();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai5 bai5 = new Bai5();
            bai5.ShowDialog();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Bai2 Bài2 = new Bai2();
            Bài2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bai6 bai6 = new Bai6();
            bai6.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai3 Bài3 = new Bai3();
            Bài3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai4 bai4 = new Bai4();
            bai4.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bai7 bai7 = new Bai7();
            bai7.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bai8 bai8 = new Bai8();
            bai8.ShowDialog();
        }
    }
}
