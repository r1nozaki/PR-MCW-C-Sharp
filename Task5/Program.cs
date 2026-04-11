using System.Text.Json;

namespace Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Dog { Name = "Рекс", BarkVolume = 80 },
                new Cat { Name = "Мурка", Lives = 9 }
            };

            string json = JsonSerializer.Serialize(animals, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine("Серіалізований список з типами:");
            Console.WriteLine(json);

            Console.WriteLine("\n--- Десеріалізація ---");

            List<Animal> restoredAnimals = JsonSerializer.Deserialize<List<Animal>>(json);

            foreach (var animal in restoredAnimals)
            {
                if (animal is Dog dog)
                {
                    Console.WriteLine($"Це Собака: {dog.Name}, Гучність гавкання: {dog.BarkVolume}");
                }
                else if (animal is Cat cat)
                {
                    Console.WriteLine($"Це Кіт: {cat.Name}, Кількість життів: {cat.Lives}");
                }
            }
        }
    }
}
