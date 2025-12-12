namespace Bai06
{
    partial class Send_Mail
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
            this.lb_From = new System.Windows.Forms.Label();
            this.txt_From = new System.Windows.Forms.TextBox();
            this.CheckHTML = new System.Windows.Forms.CheckBox();
            this.txt_Mail_Content = new System.Windows.Forms.RichTextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.lb_Subject = new System.Windows.Forms.Label();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.lb_To = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Body = new System.Windows.Forms.Label();
            this.txt_Attachment = new System.Windows.Forms.TextBox();
            this.lb_Attachment = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.File_URL = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lb_From
            // 
            this.lb_From.AutoSize = true;
            this.lb_From.Font = new System.Drawing.Font("Arial   ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_From.Location = new System.Drawing.Point(23, 25);
            this.lb_From.Name = "lb_From";
            this.lb_From.Size = new System.Drawing.Size(57, 23);
            this.lb_From.TabIndex = 0;
            this.lb_From.Text = "From";
            // 
            // txt_From
            // 
            this.txt_From.Enabled = false;
            this.txt_From.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_From.Location = new System.Drawing.Point(121, 22);
            this.txt_From.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_From.Name = "txt_From";
            this.txt_From.Size = new System.Drawing.Size(687, 30);
            this.txt_From.TabIndex = 1;
            // 
            // CheckHTML
            // 
            this.CheckHTML.AutoSize = true;
            this.CheckHTML.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckHTML.Location = new System.Drawing.Point(121, 186);
            this.CheckHTML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckHTML.Name = "CheckHTML";
            this.CheckHTML.Size = new System.Drawing.Size(85, 27);
            this.CheckHTML.TabIndex = 2;
            this.CheckHTML.Text = "HTML";
            this.CheckHTML.UseVisualStyleBackColor = true;
            // 
            // txt_Mail_Content
            // 
            this.txt_Mail_Content.Font = new System.Drawing.Font("Arial   ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mail_Content.Location = new System.Drawing.Point(17, 227);
            this.txt_Mail_Content.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Mail_Content.Name = "txt_Mail_Content";
            this.txt_Mail_Content.Size = new System.Drawing.Size(791, 330);
            this.txt_Mail_Content.TabIndex = 3;
            this.txt_Mail_Content.Text = "Hello World!";
            // 
            // btn_Browse
            // 
            this.btn_Browse.Font = new System.Drawing.Font("Arial   ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.Location = new System.Drawing.Point(709, 584);
            this.btn_Browse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(99, 38);
            this.btn_Browse.TabIndex = 4;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // txt_Subject
            // 
            this.txt_Subject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subject.Location = new System.Drawing.Point(121, 142);
            this.txt_Subject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(687, 30);
            this.txt_Subject.TabIndex = 6;
            this.txt_Subject.Text = "Test";
            // 
            // lb_Subject
            // 
            this.lb_Subject.AutoSize = true;
            this.lb_Subject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Subject.Location = new System.Drawing.Point(23, 145);
            this.lb_Subject.Name = "lb_Subject";
            this.lb_Subject.Size = new System.Drawing.Size(75, 23);
            this.lb_Subject.TabIndex = 5;
            this.lb_Subject.Text = "Subject";
            // 
            // txt_To
            // 
            this.txt_To.Font = new System.Drawing.Font("Arial   ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_To.Location = new System.Drawing.Point(121, 102);
            this.txt_To.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(687, 31);
            this.txt_To.TabIndex = 8;
            this.txt_To.Text = "wonjong.bb@gmail.com";
            // 
            // lb_To
            // 
            this.lb_To.AutoSize = true;
            this.lb_To.Font = new System.Drawing.Font("Arial   ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_To.Location = new System.Drawing.Point(23, 105);
            this.lb_To.Name = "lb_To";
            this.lb_To.Size = new System.Drawing.Size(33, 23);
            this.lb_To.TabIndex = 7;
            this.lb_To.Text = "To";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(121, 62);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(687, 30);
            this.txt_Name.TabIndex = 10;
            this.txt_Name.Text = "Nhat Thanh";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Arial   ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(23, 65);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(63, 23);
            this.lb_Name.TabIndex = 9;
            this.lb_Name.Text = "Name";
            // 
            // lb_Body
            // 
            this.lb_Body.AutoSize = true;
            this.lb_Body.Font = new System.Drawing.Font("Arial   ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Body.Location = new System.Drawing.Point(23, 186);
            this.lb_Body.Name = "lb_Body";
            this.lb_Body.Size = new System.Drawing.Size(55, 23);
            this.lb_Body.TabIndex = 11;
            this.lb_Body.Text = "Body";
            // 
            // txt_Attachment
            // 
            this.txt_Attachment.Font = new System.Drawing.Font("Arial   ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Attachment.Location = new System.Drawing.Point(128, 589);
            this.txt_Attachment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Attachment.Name = "txt_Attachment";
            this.txt_Attachment.Size = new System.Drawing.Size(548, 31);
            this.txt_Attachment.TabIndex = 13;
            // 
            // lb_Attachment
            // 
            this.lb_Attachment.AutoSize = true;
            this.lb_Attachment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Attachment.Location = new System.Drawing.Point(13, 592);
            this.lb_Attachment.Name = "lb_Attachment";
            this.lb_Attachment.Size = new System.Drawing.Size(109, 23);
            this.lb_Attachment.TabIndex = 12;
            this.lb_Attachment.Text = "Attachment";
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(671, 643);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(137, 49);
            this.btn_Send.TabIndex = 14;
            this.btn_Send.Text = "SEND MAIL";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // File_URL
            // 
            this.File_URL.FileName = "openFileDialog1";
            // 
            // Send_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 713);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_Attachment);
            this.Controls.Add(this.lb_Attachment);
            this.Controls.Add(this.lb_Body);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.lb_To);
            this.Controls.Add(this.txt_Subject);
            this.Controls.Add(this.lb_Subject);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.txt_Mail_Content);
            this.Controls.Add(this.CheckHTML);
            this.Controls.Add(this.txt_From);
            this.Controls.Add(this.lb_From);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Send_Mail";
            this.Text = "Send Mail";
            this.Load += new System.EventHandler(this.Send_Mail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_From;
        private System.Windows.Forms.TextBox txt_From;
        private System.Windows.Forms.CheckBox CheckHTML;
        private System.Windows.Forms.RichTextBox txt_Mail_Content;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Label lb_Subject;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.Label lb_To;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Body;
        private System.Windows.Forms.TextBox txt_Attachment;
        private System.Windows.Forms.Label lb_Attachment;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.OpenFileDialog File_URL;
    }
}