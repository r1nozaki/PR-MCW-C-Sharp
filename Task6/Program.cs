using System.Text.Json;

namespace Task6
{
    public class Program
    {
        static void Main(string[] args)
        {
            string json = "{\"Name\":\"Player\"}"; 
            var player = JsonSerializer.Deserialize<Player>(json);
            player.Inventory ??= new(); 
            Console.WriteLine($"{player.Name} has {player.Inventory.Items.Count} items.");
        }
    }
}
+