using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Operations
{
    public static class TextOperations
    { 
        public static string ToUpperCase(string input)
        {
            return input.ToUpper();
        }
        public static string CountCharacters(string input)
        {
            return $"Number of characters: {input.Length}";
        }
        public static string CountWords(string input)
        {
            int count = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
                return $"Word count: {count}";
        }
    }
}
