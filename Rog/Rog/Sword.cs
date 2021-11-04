using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rog
{
    class Sword
    {
        public int damage;
        public int attack_speed;
        public int DPS;
        public int DMIN;
        public int DMAX;
        public Sword()
        {
            DMIN = 30;
            DMAX = 70;
            Random rnd = new Random();
            damage = rnd.Next(DMIN, DMAX);
            attack_speed = 5;
            DPS = (damage * attack_speed) / 60;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Атака мечом = {DPS}");
        }
    }
}
