using System.Text.Json;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student> {
                new() { Name = "Олена", Age = 20, AverageScore = 95.5 },
                new() { Name = "Ігор", Age = 19, AverageScore = 88.0 },
                new() { Name = "Анна", Age = 21, AverageScore = 92.3 },
                new() { Name = "Максим", Age = 22, AverageScore = 75.2 },
                new() { Name = "Дмитро", Age = 20, AverageScore = 84.9 }
            };

            string path = "students.json";
            File.WriteAllText(path, JsonSerializer.Serialize(students));

            var restored = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText(path));
            restored?.ForEach(s => Console.WriteLine($"{s.Name}: {s.AverageScore}"));
        }
    }
}
