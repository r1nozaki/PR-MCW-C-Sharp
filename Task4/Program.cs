namespace Task4
{
    public class Program
    {
        static int deletedCount = 0;
        static long totalSizeDeleted = 0;
        static void Main(string[] args)
        {
            Console.Write("Введіть шлях до папки кешу: ");
            string path = Console.ReadLine();

            if (!Directory.Exists(path))
            {
                Console.WriteLine("Помилка: Папки не існує.");
                return;
            }

            CacheCleaner cleaner = new CacheCleaner();
            CleanupResult finalReport;

            Console.WriteLine("\nОберіть метод очищення:");
            Console.WriteLine("1 - Рекурсивний (ручний обхід)");
            Console.WriteLine("2 - Не рекурсивний (системний)");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Запуск рекурсивного очищення...");
                finalReport = cleaner.CleanRecursive(path);
            }
            else
            {
                Console.WriteLine("Запуск системного очищення...");
                finalReport = cleaner.CleanNonRecursive(path);
            }

            Console.WriteLine("\n--- ЗВІТ ПРО ОЧИЩЕННЯ ---");
            Console.WriteLine($"Видалено файлів: {finalReport.DeletedFilesCount}");
            Console.WriteLine($"Загальний об'єм: {finalReport.SizeInKb:F2} KB");

            Console.WriteLine("\nНатисніть будь-яку клавішу...");
            Console.ReadKey();
        }
    }
}
