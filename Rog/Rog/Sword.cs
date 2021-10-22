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
        public void GetDamage()
        {
            Random rnd = new Random();
            damage = rnd.Next(10, 50);
            attack_speed = 5;
            DPS = (damage * attack_speed) / 60;
        }
        public void GetInfo()
        {
            GetDamage();
            Console.WriteLine($"Атака мечом = {DPS}");
        }
    }
}
