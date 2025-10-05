namespace Lab01
{
    partial class Lab1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            LabelButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(152, 111);
            button1.Name = "button1";
            button1.Size = new Size(225, 62);
            button1.TabIndex = 0;
            button1.Text = "Bài 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(152, 206);
            button2.Name = "button2";
            button2.Size = new Size(225, 62);
            button2.TabIndex = 1;
            button2.Text = "Bài 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(152, 303);
            button3.Name = "button3";
            button3.Size = new Size(225, 62);
            button3.TabIndex = 2;
            button3.Text = "Bài 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(152, 394);
            button4.Name = "button4";
            button4.Size = new Size(225, 62);
            button4.TabIndex = 3;
            button4.Text = "Bài 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(560, 111);
            button5.Name = "button5";
            button5.Size = new Size(227, 62);
            button5.TabIndex = 4;
            button5.Text = "Bài 5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(560, 206);
            button6.Name = "button6";
            button6.Size = new Size(227, 62);
            button6.TabIndex = 5;
            button6.Text = "Bài 6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(560, 303);
            button7.Name = "button7";
            button7.Size = new Size(227, 62);
            button7.TabIndex = 6;
            button7.Text = "Bài 7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(560, 394);
            button8.Name = "button8";
            button8.Size = new Size(227, 62);
            button8.TabIndex = 7;
            button8.Text = "Bài 8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // LabelButton
            // 
            LabelButton.BackColor = Color.Thistle;
            LabelButton.Enabled = false;
            LabelButton.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelButton.Location = new Point(349, 28);
            LabelButton.Name = "LabelButton";
            LabelButton.Size = new Size(227, 62);
            LabelButton.TabIndex = 9;
            LabelButton.Text = "Lab 1";
            LabelButton.UseVisualStyleBackColor = false;
            // 
            // Lab1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkMagenta;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(939, 520);
            Controls.Add(LabelButton);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Lab1";
            Text = "Bài Tập Thực hành 1 - 24520907";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button LabelButton;
    }
}
