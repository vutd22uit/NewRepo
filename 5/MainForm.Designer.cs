namespace EmailClient
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblImapServer;
        private System.Windows.Forms.Label lblSmtpServer;
        private System.Windows.Forms.Label lblImapPort;
        private System.Windows.Forms.Label lblSmtpPort;
        private System.Windows.Forms.TextBox txtImapServer;
        private System.Windows.Forms.TextBox txtSmtpServer;
        private System.Windows.Forms.NumericUpDown nudImapPort;
        private System.Windows.Forms.NumericUpDown nudSmtpPort;
        private System.Windows.Forms.ListView lvEmails;
        private System.Windows.Forms.ColumnHeader colFrom;
        private System.Windows.Forms.ColumnHeader colSubject;
        private System.Windows.Forms.ColumnHeader colDateTime;
        private System.Windows.Forms.TextBox txtEmailBody;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtMessageBody;
        private System.Windows.Forms.Button btnOpenSendEmailForm;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblImapServer = new System.Windows.Forms.Label();
            this.lblSmtpServer = new System.Windows.Forms.Label();
            this.lblImapPort = new System.Windows.Forms.Label();
            this.lblSmtpPort = new System.Windows.Forms.Label();
            this.txtImapServer = new System.Windows.Forms.TextBox();
            this.txtSmtpServer = new System.Windows.Forms.TextBox();
            this.nudImapPort = new System.Windows.Forms.NumericUpDown();
            this.nudSmtpPort = new System.Windows.Forms.NumericUpDown();
            this.lvEmails = new System.Windows.Forms.ListView();
            this.colFrom = new System.Windows.Forms.ColumnHeader();
            this.colSubject = new System.Windows.Forms.ColumnHeader();
            this.colDateTime = new System.Windows.Forms.ColumnHeader();
            this.txtEmailBody = new System.Windows.Forms.TextBox();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtMessageBody = new System.Windows.Forms.TextBox();
            this.btnOpenSendEmailForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudImapPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSmtpPort)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 15);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 44);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 15);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(80, 12);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(80, 41);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(192, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(80, 70);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(192, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnOpenSendEmailForm
            // 
            this.btnOpenSendEmailForm.Location = new System.Drawing.Point(80, 99);
            this.btnOpenSendEmailForm.Name = "btnOpenSendEmailForm";
            this.btnOpenSendEmailForm.Size = new System.Drawing.Size(192, 23);
            this.btnOpenSendEmailForm.TabIndex = 18;
            this.btnOpenSendEmailForm.Text = "Gửi mail";
            this.btnOpenSendEmailForm.UseVisualStyleBackColor = true;
            this.btnOpenSendEmailForm.Click += new System.EventHandler(this.btnOpenSendEmailForm_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(80, 128);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(192, 23);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(80, 157);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(192, 23);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblImapServer
            // 
            this.lblImapServer.AutoSize = true;
            this.lblImapServer.Location = new System.Drawing.Point(290, 15);
            this.lblImapServer.Name = "lblImapServer";
            this.lblImapServer.Size = new System.Drawing.Size(76, 15);
            this.lblImapServer.TabIndex = 5;
            this.lblImapServer.Text = "IMAP Server:";
            // 
            // lblSmtpServer
            // 
            this.lblSmtpServer.AutoSize = true;
            this.lblSmtpServer.Location = new System.Drawing.Point(290, 44);
            this.lblSmtpServer.Name = "lblSmtpServer";
            this.lblSmtpServer.Size = new System.Drawing.Size(78, 15);
            this.lblSmtpServer.TabIndex = 6;
            this.lblSmtpServer.Text = "SMTP Server:";
            // 
            // lblImapPort
            // 
            this.lblImapPort.AutoSize = true;
            this.lblImapPort.Location = new System.Drawing.Point(540, 15);
            this.lblImapPort.Name = "lblImapPort";
            this.lblImapPort.Size = new System.Drawing.Size(31, 15);
            this.lblImapPort.TabIndex = 7;
            this.lblImapPort.Text = "Port:";
            // 
            // lblSmtpPort
            // 
            this.lblSmtpPort.AutoSize = true;
            this.lblSmtpPort.Location = new System.Drawing.Point(540, 44);
            this.lblSmtpPort.Name = "lblSmtpPort";
            this.lblSmtpPort.Size = new System.Drawing.Size(31, 15);
            this.lblSmtpPort.TabIndex = 8;
            this.lblSmtpPort.Text = "Port:";
            // 
            // txtImapServer
            // 
            this.txtImapServer.Location = new System.Drawing.Point(372, 12);
            this.txtImapServer.Name = "txtImapServer";
            this.txtImapServer.Size = new System.Drawing.Size(162, 23);
            this.txtImapServer.TabIndex = 9;
            this.txtImapServer.Text = "imap.gmail.com";
            // 
            // txtSmtpServer
            // 
            this.txtSmtpServer.Location = new System.Drawing.Point(372, 41);
            this.txtSmtpServer.Name = "txtSmtpServer";
            this.txtSmtpServer.Size = new System.Drawing.Size(162, 23);
            this.txtSmtpServer.TabIndex = 10;
            this.txtSmtpServer.Text = "smtp.gmail.com";
            // 
            // nudImapPort
            // 
            this.nudImapPort.Location = new System.Drawing.Point(577, 12);
            this.nudImapPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudImapPort.Name = "nudImapPort";
            this.nudImapPort.Size = new System.Drawing.Size(58, 23);
            this.nudImapPort.TabIndex = 11;
            this.nudImapPort.Value = new decimal(new int[] {
            993,
            0,
            0,
            0});
            // 
            // nudSmtpPort
            // 
            this.nudSmtpPort.Location = new System.Drawing.Point(577, 41);
            this.nudSmtpPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudSmtpPort.Name = "nudSmtpPort";
            this.nudSmtpPort.Size = new System.Drawing.Size(58, 23);
            this.nudSmtpPort.TabIndex = 12;
            this.nudSmtpPort.Value = new decimal(new int[] {
            465,
            0,
            0,
            0});
            // 
            // lvEmails
            // 
            this.lvEmails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFrom,
            this.colSubject,
            this.colDateTime});
            this.lvEmails.Location = new System.Drawing.Point(12, 199);
            this.lvEmails.Name = "lvEmails";
            this.lvEmails.Size = new System.Drawing.Size(623, 200);
            this.lvEmails.TabIndex = 13;
            this.lvEmails.UseCompatibleStateImageBehavior = false;
            this.lvEmails.View = System.Windows.Forms.View.Details;
            this.lvEmails.SelectedIndexChanged += new System.EventHandler(this.lvEmails_SelectedIndexChanged);
            // 
            // colFrom
            // 
            this.colFrom.Text = "From";
            this.colFrom.Width = 200;
            // 
            // colSubject
            // 
            this.colSubject.Text = "Subject";
            this.colSubject.Width = 300;
            // 
            // colDateTime
            // 
            this.colDateTime.Text = "Datetime";
            this.colDateTime.Width = 120;
            // 
            // txtEmailBody
            // 
            this.txtEmailBody.Location = new System.Drawing.Point(12, 405);
            this.txtEmailBody.Multiline = true;
            this.txtEmailBody.Name = "txtEmailBody";
            this.txtEmailBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmailBody.Size = new System.Drawing.Size(623, 100);
            this.txtEmailBody.TabIndex = 14;
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(12, 511);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(200, 23);
            this.txtRecipient.TabIndex = 15;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(218, 511);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(200, 23);
            this.txtSubject.TabIndex = 16;
            // 
            // txtMessageBody
            // 
            this.txtMessageBody.Location = new System.Drawing.Point(12, 540);
            this.txtMessageBody.Multiline = true;
            this.txtMessageBody.Name = "txtMessageBody";
            this.txtMessageBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageBody.Size = new System.Drawing.Size(623, 100);
            this.txtMessageBody.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 651);
            this.Controls.Add(this.txtMessageBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtRecipient);
            this.Controls.Add(this.txtEmailBody);
            this.Controls.Add(this.lvEmails);
            this.Controls.Add(this.nudSmtpPort);
            this.Controls.Add(this.nudImapPort);
            this.Controls.Add(this.txtSmtpServer);
            this.Controls.Add(this.txtImapServer);
            this.Controls.Add(this.lblSmtpPort);
            this.Controls.Add(this.lblImapPort);
            this.Controls.Add(this.lblSmtpServer);
            this.Controls.Add(this.lblImapServer);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOpenSendEmailForm);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Name = "MainForm";
            this.Text = "Email Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudImapPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSmtpPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
