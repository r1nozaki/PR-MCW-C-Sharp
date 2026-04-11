using System.Text.Json;

namespace Task1
{
    public class Program
    {
        private const string FilePath = "tasks.json";
        private static List<TaskItem> _tasks = new();

        static void Main()
        {
            LoadData();
            RunMenu();
            SaveData();
        }

        private static void LoadData()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                _tasks = JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new();
            }
        }

        private static void SaveData()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(FilePath, JsonSerializer.Serialize(_tasks, options));
        }

        private static void RunMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Додати 2. Статус 3. Список 4. Вихід");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Назва: ");
                        _tasks.Add(new TaskItem { Title = Console.ReadLine() }); break;
                    case "2":
                        Console.Write("Номер: ");
                        if (int.TryParse(Console.ReadLine(), out int i) && i <= _tasks.Count)
                            _tasks[i - 1].IsCompleted = !_tasks[i - 1].IsCompleted; break;
                    case "3":
                        _tasks.ForEach(t => Console.WriteLine($"[{(t.IsCompleted ? "X" : " ")}] {t.Title}")); break;
                    case "4": return;
                }
            }
        }
    }
}
