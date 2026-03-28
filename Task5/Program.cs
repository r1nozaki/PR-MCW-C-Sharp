namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = args.Length > 0 ? args[0] : Directory.GetCurrentDirectory();

            if (!Directory.Exists(path))
            {
                Console.WriteLine("Invalid path.");
                return;
            }

            DirectoryInfo di = new DirectoryInfo(path);

            var allFiles = di.GetFiles("*.*", SearchOption.AllDirectories);
            var allFolders = di.GetDirectories("*.*", SearchOption.AllDirectories);

            long totalSize = allFiles.Sum(f => f.Length);
            var largestFile = allFiles.OrderByDescending(f => f.Length).FirstOrDefault();

            Console.WriteLine($"Analyzer Report for: {path}");
            Console.WriteLine($"Folders: {allFolders.Length}");
            Console.WriteLine($"Files: {allFiles.Length}");
            Console.WriteLine($"Total size: {totalSize / (1024.0 * 1024.0):F2} MB");

            if (largestFile != null)
                Console.WriteLine($"Largest file: {largestFile.Name} ({largestFile.Length / 1024.0:F2} KB)");
        }
    }
}
