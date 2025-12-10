namespace Bai01
{
    partial class Form1
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblBody = new System.Windows.Forms.Label();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(40, 20);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(41, 16);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(116, 16);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(404, 22);
            this.txtFrom.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(40, 58);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(116, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(404, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(40, 92);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(27, 16);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "To:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(116, 88);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(404, 22);
            this.txtTo.TabIndex = 5;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(40, 128);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(55, 16);
            this.lblSubject.TabIndex = 6;
            this.lblSubject.Text = "Subject:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(116, 124);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(404, 22);
            this.txtSubject.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(540, 20);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 60);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(40, 165);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(42, 16);
            this.lblBody.TabIndex = 9;
            this.lblBody.Text = "Body:";
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(116, 161);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(514, 260);
            this.rtbBody.TabIndex = 10;
            this.rtbBody.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(100, 430);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 16);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 460);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.rtbBody);
            this.Controls.Add(this.lblStatus);
            this.Name = "Form1";
            this.Text = "Send Email - Lab5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.RichTextBox rtbBody;
        private System.Windows.Forms.Label lblStatus;
    }
}

