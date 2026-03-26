using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Services
{
    public static class PathService
    {
        public static string GetProjectPath()
        {
            var basePath = System.AppDomain.CurrentDomain.BaseDirectory;
            return Directory.GetParent(basePath).Parent.Parent.Parent.FullName;
        }

        public static string GetLogFilePath()
        {
            return Path.Combine(GetProjectPath(), "logPD24.txt");
        }
    }
}
