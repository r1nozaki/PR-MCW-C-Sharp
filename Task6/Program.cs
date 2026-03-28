namespace Task6
{
    public delegate bool Validator(string input);
    public class Program
    {
        static void Main(string[] args)
        {
            Validator passwordValidator = GetValidator(8);
            Validator loginValidator = GetValidator(3);

            string testPass = "12345";
            string testLogin = "Admin";

            Console.WriteLine($"Password '{testPass}' valid? {passwordValidator(testPass)}");
            Console.WriteLine($"Login '{testLogin}' valid? {loginValidator(testLogin)}");

            Console.WriteLine("\nEnter custom text to check against 8-char limit:");
            string input = Console.ReadLine();
            Console.WriteLine($"Is valid: {GetValidator(8)(input)}");
        }
        static Validator GetValidator(int minLength)
        {
            return s => s.Length >= minLength;
        }
    }
    }
}
