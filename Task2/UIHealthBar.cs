using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class UIHealthBar
    {
        public void UpdateBar(int damage, int hp)
        {
            Console.WriteLine($"[UI]: Оновлення смужки здоров'я... Поточне значення: {hp}%");
        }
    }
}
