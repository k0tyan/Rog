using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rog
{
    class Monster
    {
        public int damage;
        public int attack_speed;
        public int DPS;
        public int health;
        public int Hhealth;
        public Monster()
        {
            health = 100;
            Random rnd = new Random();
            damage = rnd.Next(5, 25);
            attack_speed = 10;
            DPS = (damage * attack_speed) / 60;
            Hero h = new Hero();
            Hhealth = h.health;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Здоровье монстра = {health}\n" +
                $"Удар монстра = {DPS}");
        }
    }
}
