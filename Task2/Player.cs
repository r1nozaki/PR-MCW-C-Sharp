using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Player
    {
        public int Health { get; private set; } = 100;

        public event Action<int, int> OnDamageReceived;

        public void TakeDamage(int amount)
        {
            Health -= amount;
            if (Health < 0) Health = 0;

            Console.WriteLine($"\n[Player]: Отримано {amount} урону. Залишилось HP: {Health}");

            OnDamageReceived?.Invoke(amount, Health);
        }
    }
}
