using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rog
{
    class Monster
    {
        protected int damage;
        protected int attack_speed;
        protected int DPS;
        protected int health;
        public int GetHealth() { return health; }
        public int GetDamage() { return DPS = (damage * attack_speed) / 60; }
        public void GetInfo()
        {
            Console.WriteLine($"Здоровье монстра = {health}\n" +
                $"Удар монстра = {DPS}");
        }
    }
    class Ghoul : Monster
    {
        public Ghoul(int attack_speed,int damage,int health)
        {
            this.attack_speed = attack_speed;
            this.damage = damage;
            this.health = health;
        }
    }
    class Evil: Monster
    {
        public Evil(int attack_speed, int damage, int health)
        {
            this.attack_speed = attack_speed;
            this.damage = damage;
            this.health = health;
        }       
    }
}
