using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rog
{
    class Fight
    {
        public int HealthMonster;
        public int DPSGun;
        public void Battle()
        {
            Gun g = new Gun();
            Monster m = new Monster();
            HealthMonster = m.health;
            DPSGun = g.DPS;
            while(HealthMonster > 0)
            {
                
                HealthMonster -= DPSGun;
                Console.WriteLine($"Здоровье монстра = {HealthMonster}");
            }
            Console.WriteLine("Монстр побежден");

        }
    }
}
