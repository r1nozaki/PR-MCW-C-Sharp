using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDataLibrary.Interfaces
{
    public interface IDataSerializer
    {
        string Serialize<T>(T data);
        T Deserialize<T>(string json);
    }
}
