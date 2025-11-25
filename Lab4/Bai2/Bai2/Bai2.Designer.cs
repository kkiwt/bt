namespace Bai2
{
    partial class Bai2
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
            btnDownLoad = new Button();
            rtbShowContent = new RichTextBox();
            txtURL = new TextBox();
            txtSaveFile = new TextBox();
            SaveFile = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnDownLoad
            // 
            btnDownLoad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDownLoad.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDownLoad.Location = new Point(842, 34);
            btnDownLoad.Margin = new Padding(4);
            btnDownLoad.Name = "btnDownLoad";
            btnDownLoad.Size = new Size(198, 42);
            btnDownLoad.TabIndex = 0;
            btnDownLoad.Text = "Download";
            btnDownLoad.UseVisualStyleBackColor = true;
            btnDownLoad.Click += btnDownLoad_Click;
            // 
            // rtbShowContent
            // 
            rtbShowContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbShowContent.Location = new Point(55, 185);
            rtbShowContent.Margin = new Padding(4);
            rtbShowContent.Name = "rtbShowContent";
            rtbShowContent.ReadOnly = true;
            rtbShowContent.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbShowContent.Size = new Size(984, 448);
            rtbShowContent.TabIndex = 1;
            rtbShowContent.Text = "";
            rtbShowContent.TextChanged += richTextBox1_TextChanged;
            // 
            // txtURL
            // 
            txtURL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtURL.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtURL.Location = new Point(195, 39);
            txtURL.Margin = new Padding(4);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(639, 35);
            txtURL.TabIndex = 2;
            // 
            // txtSaveFile
            // 
            txtSaveFile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSaveFile.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSaveFile.Location = new Point(195, 109);
            txtSaveFile.Margin = new Padding(4);
            txtSaveFile.Name = "txtSaveFile";
            txtSaveFile.Size = new Size(639, 35);
            txtSaveFile.TabIndex = 3;
            // 
            // SaveFile
            // 
            SaveFile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaveFile.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveFile.Location = new Point(842, 105);
            SaveFile.Margin = new Padding(4);
            SaveFile.Name = "SaveFile";
            SaveFile.Size = new Size(45, 41);
            SaveFile.TabIndex = 4;
            SaveFile.Text = "...";
            SaveFile.UseVisualStyleBackColor = true;
            SaveFile.Click += SaveFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 37);
            label1.Name = "label1";
            label1.Size = new Size(59, 32);
            label1.TabIndex = 5;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 107);
            label2.Name = "label2";
            label2.Size = new Size(150, 32);
            label2.TabIndex = 6;
            label2.Text = "Nơi Lưu Trữ";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 639);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SaveFile);
            Controls.Add(txtSaveFile);
            Controls.Add(txtURL);
            Controls.Add(rtbShowContent);
            Controls.Add(btnDownLoad);
            Margin = new Padding(4);
            Name = "Bai2";
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDownLoad;
        private RichTextBox rtbShowContent;
        private TextBox txtURL;
        private TextBox txtSaveFile;
        private Button SaveFile;
        private Label label1;
        private Label label2;
    }
}
