namespace Task3
{
    public delegate bool FilterPredicate(int n);
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Even numbers:");
            FilterArray(numbers, IsEven);

            Console.WriteLine("\nNumbers > 5:");
            FilterArray(numbers, IsGreaterThanFive);

            Console.WriteLine("\nOdd numbers (Lambda):");
            FilterArray(numbers, n => n % 2 != 0);
        }
        static void FilterArray(int[] numbers, FilterPredicate predicate)
        {
            foreach (var n in numbers)
            {
                if (predicate(n)) Console.Write(n + " ");
            }
            Console.WriteLine();
        }

        static bool IsEven(int n) => n % 2 == 0;
        static bool IsGreaterThanFive(int n) => n > 5;
    }
}
