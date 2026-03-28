using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class TemperatureSensor
    {
        public event Action<double> OnTemperatureChanged;

        private double _currentTemperature;

        public void SetTemperature(double newTemp)
        {
            Console.WriteLine($"\n--- Датчик: Температура змінилася до {newTemp}°C ---");
            _currentTemperature = newTemp;

            OnTemperatureChanged?.Invoke(_currentTemperature);
        }
    }
}
