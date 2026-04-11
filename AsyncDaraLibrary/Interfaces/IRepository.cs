using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDataLibrary.Interfaces
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAllAsync();
        Task SaveAllAsync(List<T> data);
        List<T> GetAll();
        void SaveAll(List<T> data);
    }
}
