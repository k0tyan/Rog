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
        public int h;
        public Monster()
        {
            health = 100;
        }
        public void GetDamage()
        {
            Random rnd = new Random();
            damage = rnd.Next(5, 25);
            attack_speed = 210;
            DPS = (damage * attack_speed) / 60;
        }
        public void GetInfo()
        {
            GetDamage();
            Console.WriteLine($"Здоровье монстра = {health}\n" +
                $"Удар монстра = {DPS}");
        }
    }
}
