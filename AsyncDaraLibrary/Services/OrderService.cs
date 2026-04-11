using AsyncDataLibrary.Interfaces;
using AsyncDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDataLibrary.Services
{
    public class OrderService
    {
        private readonly IRepository<Order> _repository;

        public OrderService(IRepository<Order> repository) => _repository = repository;
        public async Task CreateOrderAsync(Order order)
        {
            var orders = await _repository.GetAllAsync();
            orders.Add(order);
            await _repository.SaveAllAsync(orders);
        }
        public async Task<List<Order>> GetOrdersAsync() => await _repository.GetAllAsync();
    }
}
