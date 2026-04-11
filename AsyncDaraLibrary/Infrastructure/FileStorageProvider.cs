using AsyncDataLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDataLibrary.Infrastructure
{
    public class FileStorageProvider<T> : IRepository<T>
    {
        private readonly string _path;
        private readonly IDataSerializer _serializer;

        public FileStorageProvider(string fileName, IDataSerializer serializer)
        {
            _path = fileName;
            _serializer = serializer;
        }
        public async Task<List<T>> GetAllAsync()
        {
            if (!File.Exists(_path)) return new List<T>();
            string json = await File.ReadAllTextAsync(_path);
            return _serializer.Deserialize<List<T>>(json) ?? new List<T>();
        }
        public async Task SaveAllAsync(List<T> data)
        {
            string json = _serializer.Serialize(data);
            await File.WriteAllTextAsync(_path, json);
        }
        public List<T> GetAll() => !File.Exists(_path) ? new() : _serializer.Deserialize<List<T>>(File.ReadAllText(_path));
        public void SaveAll(List<T> data) => File.WriteAllText(_path, _serializer.Serialize(data));

    }
}
