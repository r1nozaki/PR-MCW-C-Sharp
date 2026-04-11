using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task3
{
    public class Book
    {
        public string Title { get; set; }
        [JsonIgnore] 
        public Author Author { get; set; }
    }
}
