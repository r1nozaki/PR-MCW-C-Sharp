using System.Text.Json;

namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var order = new Order { Id = 1, Status = OrderStatus.Processing };
            string json = JsonSerializer.Serialize(order);
            Console.WriteLine($"JSON: {json}");
        }
    }
}
