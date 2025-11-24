namespace Bai2
{
    partial class Form1
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
            button1 = new Button();
            SuspendLayout();
            // 
            // btnDownLoad
            // 
            btnDownLoad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDownLoad.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDownLoad.Location = new Point(674, 27);
            btnDownLoad.Name = "btnDownLoad";
            btnDownLoad.Size = new Size(158, 34);
            btnDownLoad.TabIndex = 0;
            btnDownLoad.Text = "DownLoad";
            btnDownLoad.UseVisualStyleBackColor = true;
            btnDownLoad.Click += btnDownLoad_Click;
            // 
            // rtbShowContent
            // 
            rtbShowContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbShowContent.Location = new Point(44, 148);
            rtbShowContent.Name = "rtbShowContent";
            rtbShowContent.ReadOnly = true;
            rtbShowContent.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbShowContent.Size = new Size(788, 359);
            rtbShowContent.TabIndex = 1;
            rtbShowContent.Text = "";
            rtbShowContent.TextChanged += richTextBox1_TextChanged;
            // 
            // txtURL
            // 
            txtURL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtURL.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtURL.Location = new Point(44, 31);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(624, 30);
            txtURL.TabIndex = 2;
            // 
            // txtSaveFile
            // 
            txtSaveFile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSaveFile.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSaveFile.Location = new Point(44, 87);
            txtSaveFile.Name = "txtSaveFile";
            txtSaveFile.Size = new Size(624, 30);
            txtSaveFile.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(674, 84);
            button1.Name = "button1";
            button1.Size = new Size(36, 33);
            button1.TabIndex = 4;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 511);
            Controls.Add(button1);
            Controls.Add(txtSaveFile);
            Controls.Add(txtURL);
            Controls.Add(rtbShowContent);
            Controls.Add(btnDownLoad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDownLoad;
        private RichTextBox rtbShowContent;
        private TextBox txtURL;
        private TextBox txtSaveFile;
        private Button button1;
    }
}
