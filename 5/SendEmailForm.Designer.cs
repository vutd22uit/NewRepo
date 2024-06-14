namespace EmailClient
{
    partial class SendEmailForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtMessageBody;
        private System.Windows.Forms.TextBox txtSenderEmail;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblSenderEmail;
        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblMessageBody;
        private System.Windows.Forms.CheckBox chkIsHtml;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.TextBox txtAttachment;
        private System.Windows.Forms.Button btnBrowseAttachment;

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
            this.txtSenderEmail = new System.Windows.Forms.TextBox();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtMessageBody = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblSenderEmail = new System.Windows.Forms.Label();
            this.lblRecipient = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblMessageBody = new System.Windows.Forms.Label();
            this.chkIsHtml = new System.Windows.Forms.CheckBox();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.txtAttachment = new System.Windows.Forms.TextBox();
            this.btnBrowseAttachment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSenderEmail
            // 
            this.txtSenderEmail.Location = new System.Drawing.Point(12, 25);
            this.txtSenderEmail.Name = "txtSenderEmail";
            this.txtSenderEmail.Size = new System.Drawing.Size(360, 20);
            this.txtSenderEmail.TabIndex = 0;
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(12, 64);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(360, 20);
            this.txtRecipient.TabIndex = 1;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(12, 103);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(360, 20);
            this.txtSubject.TabIndex = 2;
            // 
            // txtMessageBody
            // 
            this.txtMessageBody.Location = new System.Drawing.Point(12, 168);
            this.txtMessageBody.Multiline = true;
            this.txtMessageBody.Name = "txtMessageBody";
            this.txtMessageBody.Size = new System.Drawing.Size(360, 150);
            this.txtMessageBody.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(297, 324);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblSenderEmail
            // 
            this.lblSenderEmail.AutoSize = true;
            this.lblSenderEmail.Location = new System.Drawing.Point(12, 9);
            this.lblSenderEmail.Name = "lblSenderEmail";
            this.lblSenderEmail.Size = new System.Drawing.Size(73, 13);
            this.lblSenderEmail.TabIndex = 5;
            this.lblSenderEmail.Text = "Sender Email:";
            // 
            // lblRecipient
            // 
            this.lblRecipient.AutoSize = true;
            this.lblRecipient.Location = new System.Drawing.Point(12, 48);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(55, 13);
            this.lblRecipient.TabIndex = 6;
            this.lblRecipient.Text = "Recipient:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(12, 87);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.TabIndex = 7;
            this.lblSubject.Text = "Subject:";
            // 
            // lblMessageBody
            // 
            this.lblMessageBody.AutoSize = true;
            this.lblMessageBody.Location = new System.Drawing.Point(12, 152);
            this.lblMessageBody.Name = "lblMessageBody";
            this.lblMessageBody.Size = new System.Drawing.Size(78, 13);
            this.lblMessageBody.TabIndex = 8;
            this.lblMessageBody.Text = "Message Body:";
            // 
            // chkIsHtml
            // 
            this.chkIsHtml.AutoSize = true;
            this.chkIsHtml.Location = new System.Drawing.Point(12, 324);
            this.chkIsHtml.Name = "chkIsHtml";
            this.chkIsHtml.Size = new System.Drawing.Size(56, 17);
            this.chkIsHtml.TabIndex = 9;
            this.chkIsHtml.Text = "HTML";
            this.chkIsHtml.UseVisualStyleBackColor = true;
            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Location = new System.Drawing.Point(12, 129);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(65, 13);
            this.lblAttachment.TabIndex = 10;
            this.lblAttachment.Text = "Attachment:";
            // 
            // txtAttachment
            // 
            this.txtAttachment.Location = new System.Drawing.Point(83, 126);
            this.txtAttachment.Name = "txtAttachment";
            this.txtAttachment.Size = new System.Drawing.Size(217, 20);
            this.txtAttachment.TabIndex = 11;
            // 
            // btnBrowseAttachment
            // 
            this.btnBrowseAttachment.Location = new System.Drawing.Point(306, 124);
            this.btnBrowseAttachment.Name = "btnBrowseAttachment";
            this.btnBrowseAttachment.Size = new System.Drawing.Size(66, 23);
            this.btnBrowseAttachment.TabIndex = 12;
            this.btnBrowseAttachment.Text = "Browse...";
            this.btnBrowseAttachment.UseVisualStyleBackColor = true;
            this.btnBrowseAttachment.Click += new System.EventHandler(this.btnBrowseAttachment_Click);
            // 
            // SendEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnBrowseAttachment);
            this.Controls.Add(this.txtAttachment);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.chkIsHtml);
            this.Controls.Add(this.lblMessageBody);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblRecipient);
            this.Controls.Add(this.lblSenderEmail);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessageBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtRecipient);
            this.Controls.Add(this.txtSenderEmail);
            this.Name = "SendEmailForm";
            this.Text = "Send Email";
            this.Load += new System.EventHandler(this.SendEmailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
