namespace Bai1
{
    partial class Bai1_Lab4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            URL = new TextBox();
            Get = new Button();
            NoiDung = new RichTextBox();
            SuspendLayout();
            // 
            // URL
            // 
            URL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            URL.Location = new Point(22, 32);
            URL.Name = "URL";
            URL.Size = new Size(606, 34);
            URL.TabIndex = 0;
            // 
            // Get
            // 
            Get.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Get.Location = new Point(656, 32);
            Get.Name = "Get";
            Get.Size = new Size(116, 34);
            Get.TabIndex = 1;
            Get.Text = "GET";
            Get.UseVisualStyleBackColor = true;
            Get.Click += Get_Click;
            // 
            // NoiDung
            // 
            NoiDung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoiDung.Location = new Point(22, 98);
            NoiDung.Name = "NoiDung";
            NoiDung.Size = new Size(750, 525);
            NoiDung.TabIndex = 2;
            NoiDung.Text = "";
            // 
            // Bai1_Lab4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 649);
            Controls.Add(NoiDung);
            Controls.Add(Get);
            Controls.Add(URL);
            Name = "Bai1_Lab4";
            Text = "Bai1_Lab4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox URL;
        private Button Get;
        private RichTextBox NoiDung;
    }
}