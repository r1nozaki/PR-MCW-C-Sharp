using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class GameLogger
    {
        public void LogDamage(int damage, int hp)
        {
            Console.WriteLine($"[Log]: {DateTime.Now:HH:mm:ss} | Урон: {damage} | Залишок HP: {hp}");
        }
    }
}
