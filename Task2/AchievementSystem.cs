using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class AchievementSystem
    {
        private bool _halfHealthAchieved = false;
        private bool _firstDeathAchieved = false;

        public void CheckAchievements(int damage, int hp)
        {
            if (hp <= 50 && !_halfHealthAchieved)
            {
                Console.WriteLine("[Achievement]: !!! ВІДКРИТО ДОСЯГНЕННЯ: 'Half Health' !!!");
                _halfHealthAchieved = true;
            }

            if (hp <= 0 && !_firstDeathAchieved)
            {
                Console.WriteLine("[Achievement]: !!! ВІДКРИТО ДОСЯГНЕННЯ: 'First Death' !!!");
                _firstDeathAchieved = true;
            }
        }
    }
}
