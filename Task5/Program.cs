namespace Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Logger myLogger = new Logger();

            myLogger.LogHandler = (msg) =>
            {
                Console.WriteLine($"[Console Log]: {msg}");
            };

            myLogger.Log("Система запущена.");

            Console.WriteLine(new string('-', 30));

            myLogger.LogHandler = (msg) =>
            {
                Console.WriteLine($"[UPPERCASE LOG]: {msg.ToUpper()}");
            };

            myLogger.Log("Виявлено критичну помилку!");

            myLogger.LogHandler += (msg) =>
            {
                Console.WriteLine($"[Timestamp]: {DateTime.Now}");
            };

            Console.WriteLine(new string('-', 30));
            myLogger.Log("Завершення роботи.");

            Console.ReadKey();
        }
    }
}
