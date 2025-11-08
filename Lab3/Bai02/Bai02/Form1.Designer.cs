namespace Bai02
{
    partial class TCPlistener
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
            listen = new Button();
            listViewCommand = new ListView();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // listen
            // 
            listen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listen.Location = new Point(432, 22);
            listen.Name = "listen";
            listen.Size = new Size(132, 42);
            listen.TabIndex = 1;
            listen.Text = "LISTEN";
            listen.UseVisualStyleBackColor = true;
            listen.Click += listen_Click;
            // 
            // listViewCommand
            // 
            listViewCommand.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listViewCommand.Location = new Point(12, 80);
            listViewCommand.Name = "listViewCommand";
            listViewCommand.Size = new Size(552, 506);
            listViewCommand.TabIndex = 2;
            listViewCommand.UseCompatibleStateImageBehavior = false;
            listViewCommand.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 300;
            // 
            // TCPlistener
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 598);
            Controls.Add(listViewCommand);
            Controls.Add(listen);
            Name = "TCPlistener";
            Text = "Lab03_Bai02";
            ResumeLayout(false);
        }

        #endregion
        private Button listen;
        private ListView listViewCommand;
        private ColumnHeader columnHeader1;
    }
}
