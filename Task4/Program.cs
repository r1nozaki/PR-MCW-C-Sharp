namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> mathFunc = (a, b) => a * b;
            Console.WriteLine($"Func Multiply (12 * 3): {mathFunc(12, 3)}");

            List<string> students = new List<string> { "Alice", "Bob", "Andrew", "Charlie", "Anna" };
            char searchLetter = 'A';

            List<string> filteredStudents = students.FindAll(s => s.StartsWith(searchLetter.ToString()));

            Console.WriteLine($"\nStudents starting with '{searchLetter}':");
            filteredStudents.ForEach(s => Console.WriteLine(s));
        }
    }
}
