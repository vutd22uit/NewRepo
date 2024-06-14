using System;
using System.Linq;
using System.Windows.Forms;
using MimeKit;

namespace EmailClient
{
    public partial class EmailDetailForm : Form
    {
        private readonly MimeMessage _message;

        public EmailDetailForm(MimeMessage message)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));

            InitializeComponent();
            _message = message;
            LoadEmailDetails();
        }

        private void LoadEmailDetails()
        {
            if (_message != null)
            {
                txtFrom.Text = string.Join(", ", _message.From.Select(f => f.ToString()));
                txtTo.Text = string.Join(", ", _message.To.Select(t => t.ToString()));
                txtSubject.Text = _message.Subject ?? string.Empty;

                var bodyHtml = _message.HtmlBody ?? _message.TextBody ?? string.Empty;
                webBrowserBody.DocumentText = bodyHtml;
            }
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            var sendEmailForm = new SendEmailForm(_message);
            sendEmailForm.Show();
        }

        private void EmailDetailForm_Load(object sender, EventArgs e)
        {
            // Additional initialization code can be added here if needed
        }
    }
}
