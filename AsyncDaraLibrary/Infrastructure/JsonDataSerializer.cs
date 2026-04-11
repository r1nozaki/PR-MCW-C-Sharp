using AsyncDataLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AsyncDataLibrary.Infrastructure
{
    public class JsonDataSerializer : IDataSerializer
    {
        private readonly JsonSerializerOptions _options = new() { WriteIndented = true };
        public string Serialize<T>(T data) => JsonSerializer.Serialize(data, _options);
        public T Deserialize<T>(string json) => JsonSerializer.Deserialize<T>(json);
    }
}
