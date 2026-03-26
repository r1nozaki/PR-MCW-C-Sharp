using Task2.Publishers;
using Task2.Subscribers;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var publisher = new MessagePublisher();
            var logger = new FileLogger();

            logger.Subscribe(publisher);

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Введи текст: ");
                string input = Console.ReadLine();

                publisher.Send(input);
            }
        }
    }
}
