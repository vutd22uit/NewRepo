using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

using _5.Properties;

namespace EmailClient
{
    public partial class MainForm : Form
    {
        private ImapClient _imapClient;
        private SmtpClient _smtpClient;

        public MainForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(MainForm_Load);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load saved settings
            txtEmail.Text = Settings.Default.Email;
            txtPassword.Text = Settings.Default.Password;
            txtImapServer.Text = "imap.gmail.com";
            nudImapPort.Value = 993;
            txtSmtpServer.Text = "smtp.gmail.com";
            nudSmtpPort.Value = 465;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            await LoginAsync();
        }

        private async Task LoginAsync()
        {
            try
            {
                _imapClient = new ImapClient();
                await _imapClient.ConnectAsync(txtImapServer.Text, (int)nudImapPort.Value, SecureSocketOptions.SslOnConnect);
                await _imapClient.AuthenticateAsync(txtEmail.Text, txtPassword.Text);

                _smtpClient = new SmtpClient();
                await _smtpClient.ConnectAsync(txtSmtpServer.Text, (int)nudSmtpPort.Value, SecureSocketOptions.SslOnConnect);
                await _smtpClient.AuthenticateAsync(txtEmail.Text, txtPassword.Text);

                // Save settings
                Settings.Default.Email = txtEmail.Text;
                Settings.Default.Password = txtPassword.Text;
                Settings.Default.Save();

                MessageBox.Show("Đăng nhập thành công!");
                await LoadEmailListAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại: " + ex.Message);
            }
        }

        private async Task LoadEmailListAsync()
        {
            if (_imapClient == null || !_imapClient.IsConnected)
            {
                MessageBox.Show("IMAP client is not connected.");
                return;
            }

            try
            {
                var inbox = _imapClient.Inbox;
                await inbox.OpenAsync(MailKit.FolderAccess.ReadOnly);

                lvEmails.Items.Clear();

                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = await inbox.GetMessageAsync(i);
                    var item = new ListViewItem(new[] { i.ToString(), message.From.ToString(), message.Subject, message.Date.ToString() });
                    item.Tag = message;
                    lvEmails.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load emails: " + ex.Message);
            }
        }

        private void lvEmails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmails.SelectedItems.Count > 0)
            {
                var selectedMessage = (MimeMessage)lvEmails.SelectedItems[0].Tag;
                var emailDetailForm = new EmailDetailForm(selectedMessage);
                emailDetailForm.Show();
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            await SendEmailAsync();
        }

        private async Task SendEmailAsync()
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Your Name", txtEmail.Text));
                message.To.Add(new MailboxAddress("", txtRecipient.Text));
                message.Subject = txtSubject.Text;

                var body = new TextPart("plain")
                {
                    Text = txtMessageBody.Text
                };
                message.Body = body;

                await _smtpClient.SendAsync(message);
                MessageBox.Show("Email đã được gửi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gửi email thất bại: " + ex.Message);
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadEmailListAsync();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (_imapClient != null && _imapClient.IsConnected)
            {
                _imapClient.Disconnect(true);
            }
            if (_smtpClient != null && _smtpClient.IsConnected)
            {
                _smtpClient.Disconnect(true);
            }
            MessageBox.Show("Đăng xuất thành công!");
        }

        private void btnOpenSendEmailForm_Click(object sender, EventArgs e)
        {
            var sendEmailForm = new SendEmailForm(_smtpClient);
            sendEmailForm.Show();
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            if (lvEmails.SelectedItems.Count > 0)
            {
                var selectedMessage = (MimeMessage)lvEmails.SelectedItems[0].Tag;
                var sendEmailForm = new SendEmailForm(_smtpClient, selectedMessage);
                sendEmailForm.Show();
            }
        }
    }
}
