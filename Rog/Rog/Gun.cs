using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rog
{
    class Gun
    {
        public int damage;
        public int attack_speed;
        public int DPS;
        public Gun()
        {
            Random rnd = new Random();
            damage = rnd.Next(50, 100);
            attack_speed = rnd.Next(5, 10);
            DPS = (damage * attack_speed) / 60;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Атака пистолета = {DPS}");
        }
    }
}
