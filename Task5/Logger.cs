using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Logger
    {
        public Action<string> LogHandler { get; set; }
        public void Log(string message)
        {
            LogHandler?.Invoke(message);
        }
    }
}
