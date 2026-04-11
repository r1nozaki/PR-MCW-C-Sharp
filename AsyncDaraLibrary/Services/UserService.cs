using AsyncDataLibrary.Interfaces;
using AsyncDataLibrary.Models
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDataLibrary.Services
{
    public class UserService
    {
        private readonly IRepository<User> _repository;

        public UserService(IRepository<User> repository) => _repository = repository;
        public async Task AddUsersAsync(User user)
        {
            var users = await _repository.GetAllAsync();
            users.Add(user);
            await _repository.SaveAllAsync(users);
        }
        public async Task<List<User>> GetUsersAsync() => await _repository.GetAllAsync();
    }
}
