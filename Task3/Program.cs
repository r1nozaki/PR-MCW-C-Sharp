namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть шлях до папки: ");
            string path = Console.ReadLine();

            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

                FileInfo largestFile = null;
                long maxSize = -1;

                foreach (string filePath in files)
                {
                    FileInfo fi = new FileInfo(filePath);

                    if (fi.Length > maxSize)
                    {
                        maxSize = fi.Length;
                        largestFile = fi;
                    }
                }

                if (largestFile != null)
                {
                    Console.WriteLine("\nНайбільший знайдений файл:");
                    Console.WriteLine($"Name: {largestFile.Name}");

                    double sizeInMb = largestFile.Length / 1048576.0;
                    Console.WriteLine($"Size: {sizeInMb:F2} MB");

                    Console.WriteLine($"Path: {largestFile.FullName}");
                }
                else
                {
                    Console.WriteLine("У вказаній папці файлів не знайдено.");
                }
            }
            else
            {
                Console.WriteLine("Шлях не знайдено. Перевірте правильність введення.");
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу...");
            Console.ReadKey();
        }
    }
}
