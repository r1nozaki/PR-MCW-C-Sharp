namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputPath = "story.txt";
            string outputPath = "report.txt";

            if (!File.Exists(inputPath))
                File.WriteAllText(inputPath, "Hello world!\nThis is a test story.\nC# is awesome.");

            int lineCount = 0;
            int wordCount = 0;
            long charCount = 0;

            using (StreamReader sr = new StreamReader(inputPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lineCount++;
                    charCount += line.Length;
                    string[] words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    wordCount += words.Length;
                }
            }
            string report = $"Lines: {lineCount}\nWords: {wordCount}\nCharacters: {charCount}";
            File.WriteAllText(outputPath, report);
            
            Console.WriteLine("Report generated in report.txt");
            Console.WriteLine(report);
        }      
    }
}
