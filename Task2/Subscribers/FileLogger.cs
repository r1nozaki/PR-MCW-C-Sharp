using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Services;

namespace Task2.Subscribers
{
    public class FileLogger
    {
        private readonly string _filePath;

        public FileLogger()
        {
            _filePath = PathService.GetLogFilePath();
        }

        public void Subscribe(Publishers.MessagePublisher publisher)
        {
            publisher.MessageSent += LogMessage;
        }

        private void LogMessage(string message)
        {
            string log = $"[{DateTime.Now:HH:mm:ss}] {message}";
            File.AppendAllText(_filePath, log + Environment.NewLine);
        }
    }
}
