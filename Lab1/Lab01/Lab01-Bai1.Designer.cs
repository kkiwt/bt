namespace Lab01
{
    partial class Bai1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Thoat = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 25F);
            label2.Location = new Point(113, 28);
            label2.Name = "label2";
            label2.Size = new Size(558, 57);
            label2.TabIndex = 1;
            label2.Text = "Tính Tổng 2 Số Nguyên";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(249, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(394, 61);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(249, 194);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 61);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 255);
            button1.Font = new Font("Segoe UI", 18F);
            button1.ForeColor = Color.Black;
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(557, 320);
            button1.Name = "button1";
            button1.Size = new Size(211, 97);
            button1.TabIndex = 5;
            button1.Text = "Tính";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(16, 117);
            label1.Name = "label1";
            label1.Size = new Size(232, 32);
            label1.TabIndex = 6;
            label1.Text = "Số nguyên thứ nhất:";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(27, 214);
            label3.Name = "label3";
            label3.Size = new Size(216, 32);
            label3.TabIndex = 7;
            label3.Text = "Số nguyên thứ hai:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(32, 320);
            label4.Name = "label4";
            label4.Size = new Size(112, 32);
            label4.TabIndex = 8;
            label4.Text = "Kết Quả: ";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(138, 300);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(394, 61);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Thoat
            // 
            Thoat.Location = new Point(391, 367);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(141, 36);
            Thoat.TabIndex = 12;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(Thoat);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Name = "Bai1";
            Text = "Bai1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Thoat;
    }

}