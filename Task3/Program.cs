using System.Text.Json;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var author = new Author { Name = "Stephen King" };
            author.Books.Add(new Book { Title = "It", Author = author });

            var options = new JsonSerializerOptions { WriteIndented = true };
            Console.WriteLine(JsonSerializer.Serialize(author, options));
        }
    }
}
