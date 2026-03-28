using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class SecuritySystem
    {
        public void CheckSafety(double temp)
        {
            if (temp > 40)
                Console.WriteLine("[Security]: !!! УВАГА: НЕБЕЗПЕЧНИЙ ПЕРЕГРІВ !!!");
            if (temp < 5)
                Console.WriteLine("[Security]: !!! УВАГА: РИЗИК ЗАМЕРЗАННЯ СИСТЕМ !!!");
        }
    }
}
