using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncDataLibrary.Interfaces;
using AsyncDataLibrary.Models


namespace AsyncDataLibrary.Services
{
    public class BookService
    {
        private readonly IRepository<Book> _repository;

        public BookService(IRepository<Book> repository) => _repository = repository;
        public async Task AddBooksAsync(Book book)
        {
            var books = await _repository.GetAllAsync();
            books.Add(book);
            await _repository.SaveAllAsync(books);
        }
        public async Task<List<Book>> GetBooksAsync() => await _repository.GetAllAsync();
    }
}
