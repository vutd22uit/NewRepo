using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;

namespace EmailClient
{
    public partial class SendEmailForm : Form
    {
        private readonly SmtpClient _smtpClient;
        private readonly MimeMessage _originalMessage;

        public SendEmailForm(SmtpClient smtpClient)
        {
            InitializeComponent();
            _smtpClient = smtpClient;
        }

        public SendEmailForm(SmtpClient smtpClient, MimeMessage originalMessage)
        {
            InitializeComponent();
            _smtpClient = smtpClient;
            _originalMessage = originalMessage;
            LoadOriginalMessage();
        }

        public SendEmailForm(MimeMessage originalMessage)
        {
            InitializeComponent();
            _originalMessage = originalMessage;
            LoadOriginalMessage();
        }

        private void LoadOriginalMessage()
        {
            if (_originalMessage != null)
            {
                txtRecipient.Text = string.Join(", ", _originalMessage.From.Select(f => f.ToString()));
                txtSubject.Text = "Re: " + _originalMessage.Subject;
                txtMessageBody.Text = $"\n\n--- Original Message ---\n{_originalMessage.TextBody}";
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Your Name", txtSenderEmail.Text));
                message.To.Add(new MailboxAddress("", txtRecipient.Text));
                message.Subject = txtSubject.Text;

                var body = chkIsHtml.Checked ? new TextPart("html") { Text = txtMessageBody.Text } : new TextPart("plain") { Text = txtMessageBody.Text };

                var multipart = new Multipart("mixed") { body };

                if (!string.IsNullOrEmpty(txtAttachment.Text) && File.Exists(txtAttachment.Text))
                {
                    var attachment = new MimePart()
                    {
                        Content = new MimeContent(File.OpenRead(txtAttachment.Text)),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = Path.GetFileName(txtAttachment.Text)
                    };
                    multipart.Add(attachment);
                }

                message.Body = multipart;

                await _smtpClient.SendAsync(message);
                MessageBox.Show("Email đã được gửi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gửi email thất bại: " + ex.Message);
            }
        }

        private void btnBrowseAttachment_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtAttachment.Text = openFileDialog.FileName;
                }
            }
        }

        private void SendEmailForm_Load(object sender, EventArgs e)
        {
            // Any initialization code when the form loads
        }
    }
}
