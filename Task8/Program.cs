using System.Text.Json;

namespace Task8
{
    public class Program
    {
        static void Main(string[] args)
        {
            string badJson = "{ \"Name\": 123 }"; 
            try
            {
                JsonSerializer.Deserialize<dynamic>(badJson);
            }
            catch (JsonException)
            {
                Console.WriteLine("Помилка формату JSON! Створено об'єкт за замовчуванням.");
            }
        }
    }
}
