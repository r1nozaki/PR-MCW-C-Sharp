using System.Text.Json;

namespace Task7
{
    public class Program
    {
        static void Main(string[] args)
        {
            string oldJson = "{\"Name\":\"Oldbie\"}";
            var p = JsonSerializer.Deserialize<Player>(oldJson);
            Console.WriteLine($"{p.Name} level: {p.Level}");
        }
    }
}
