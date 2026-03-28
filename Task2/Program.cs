namespace Task2
{
    public delegate void NotificationHandler(string message);
    public class Program
    {
        static void Main(string[] args)
        {
            NotificationHandler handler = SendEmail;
            handler += SendSMS; 

            Console.WriteLine("Invoking multicast delegate:");
            handler("System Update Successful");
        }
        static void SendEmail(string msg) => Console.WriteLine($"Email sent: {msg}");
        static void SendSMS(string msg) => Console.WriteLine($"SMS sent: {msg}");
    }
}
