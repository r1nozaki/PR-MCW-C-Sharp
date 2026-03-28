namespace Task1
{
    public delegate double MathOperation(double x, double y);
    public class Program
    {
        static void Main(string[] args)
        {
            MathOperation operation;

            operation = Add;
            Console.WriteLine($"Add: 10 + 5 = {operation(10, 5)}");

            operation = Subtract;
            Console.WriteLine($"Subtract: 10 - 5 = {operation(10, 5)}");

            operation = Multiply;
            Console.WriteLine($"Multiply: 10 * 5 = {operation(10, 5)}");

            operation = Divide;
            Console.WriteLine($"Divide: 10 / 5 = {operation(10, 5)}");
        }
        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        static double Divide(double a, double b) => b != 0 ? a / b : 0;
    }
}
