namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter directory path: ");
            string path = Console.ReadLine();

            if (Directory.Exists(path))
            {
                DirectoryInfo di = new DirectoryInfo(path);

                Console.WriteLine("\n--- Subdirectories ---");
                foreach (var dir in di.GetDirectories())
                {
                    Console.WriteLine($"[DIR] {dir.Name}");
                }

                Console.WriteLine("\n--- Files ---");
                foreach (var file in di.GetFiles())
                {
                    Console.WriteLine($"{file.Name,-20} | Size: {file.Length} bytes | Created: {file.CreationTime}");
                }
            }
            else Console.WriteLine("Directory not found.");
        }
    }
}
