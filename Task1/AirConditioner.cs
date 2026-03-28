using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class AirConditioner
    {
        public void HandleTemperature(double temp)
        {
            if (temp < 17)
                Console.WriteLine("[AC]: Увімкнено ОБІГРІВ");
            else if (temp > 25)
                Console.WriteLine("[AC]: Увімкнено ОХОЛОДЖЕННЯ");
            else
                Console.WriteLine("[AC]: Кондиціонер вимкнено (комфортна зона)");
        }
    }
}
