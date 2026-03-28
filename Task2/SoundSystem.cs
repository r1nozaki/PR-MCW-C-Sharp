using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class SoundSystem
    {
        public void PlaySounds(int damage, int hp)
        {
            Console.WriteLine("[Sound]: *Відтворення звуку болю: 'Oof!'*");

            if (hp <= 20 && hp > 0)
            {
                Console.WriteLine("[Sound]: *КРИТИЧНИЙ СТАН: Відтворення прискореного серцебиття!*");
            }
        }
    }
}
