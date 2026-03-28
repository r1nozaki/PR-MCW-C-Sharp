using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Display
    {
        public void Update(double temp)
        {
            Console.WriteLine($"[Display]: Поточна температура {temp}°C");
        }
    }
}
