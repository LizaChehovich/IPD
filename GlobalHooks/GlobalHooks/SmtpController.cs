using System.Net.Mail;

namespace GlobalHooks
{
    class SmtpController
    {
        private const string Host = "smtp.gmail.com";
        private const int Port = 587;
        private readonly ConfigurationInfo _configuration;
        private readonly SmtpClient _smtpClient;

        public SmtpController(ConfigurationInfo configuration)
        {
            _configuration = configuration;
            _smtpClient = new SmtpClient(Host, Port)
            {
                Credentials = new System.Net.NetworkCredential(_configuration.From, _configuration.Password),
                EnableSsl = true
            };
        }

        public void Send(string subject, string filePath)
        {
            var mail = new MailMessage(_configuration.From, _configuration.To, subject, string.Empty);
            using (var attachment = new Attachment(filePath))
            {
                mail.Attachments.Add(attachment);
                _smtpClient.Send(mail);
            }
        }
    }
}
