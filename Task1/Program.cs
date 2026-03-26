using Task1.Operations;
using Task1.Services;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "textPD24.txt";
            string outputFile = "resultPD24.txt";

            File.WriteAllText(outputFile, "");

            var processor = new FileProcessor();

            processor.ProcessFile(inputFile, outputFile, TextOperations.ToUpperCase);
            processor.ProcessFile(inputFile, outputFile, TextOperations.CountCharacters);
            processor.ProcessFile(inputFile, outputFile, TextOperations.CountWords);
        }
    }
}
