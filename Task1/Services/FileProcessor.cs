using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Delegates;

namespace Task1.Services
{
    public class FileProcessor
    {
        public void ProcessFile(string inputPath, string outputPath, TextOperation operation)
        {
            var lines = File.ReadAllLines(inputPath);
            foreach (var line in lines)
            {
                var result = operation(line);
                File.AppendAllText(outputPath, result + System.Environment.NewLine);
            }
        }
    }
}
