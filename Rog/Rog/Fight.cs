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
        public int HealthHero;
        public int SDPS;
        public int GDPS;
        public int MDPS;
        public void Battle()
        {
           
            int couldown = 0;
            Console.WriteLine("Вы встретили монстра выберите оружие,которым будете сражаться. 1 - пистолет, 2 - меч");
            while (HealthMonster > 0)
            {
                string c = Console.ReadLine();
                switch (c)
                {
                    case "1":
                        if (couldown != 0)
                        {
                            Console.WriteLine("Оружие перезаряжается");
                            couldown -= 1;
                        }
                        else if (couldown == 0)
                        {
                            HealthMonster -= SDPS;
                            HealthHero -= MDPS;
                            Console.WriteLine($"Здоровье монстра = {HealthMonster}, нанесенный урон = {GDPS}\n" +
                                $"Здоровье героя = {HealthHero}, полученный урон = {MDPS}");
                            couldown += 1;
                        }
                        break;
                    case "2":
                        HealthMonster -= SDPS;
                        HealthHero -= MDPS;
                        Console.WriteLine($"Здоровье монстра = {HealthMonster}, нанесенный урон = {SDPS}\n" +
                               $"Здоровье героя = {HealthHero}, полученный урон = {MDPS}");
                        couldown -= 1;
                        if (couldown < 0) { couldown = 0; }
                        break;
                }
                if (HealthMonster <= 0)
                {
                    History i = new History();
                    i.Next();
                }
                else if (HealthHero <= 0) { Console.WriteLine("Герой пал"); Environment.Exit(0); }

            }
        }
    }
    class Fight_Ghoul : Fight
    {
       public Fight_Ghoul()
       {
            Gun g = new Gun();
            Sword s = new Sword();
            Ghoul mg = new Ghoul(attack_speed: 10, damage: 20, health: 100);
            Hero h = new Hero();
            HealthMonster = mg.GetHealth();
            HealthHero = h.health;
            SDPS = s.DPS;
            GDPS = g.DPS;
            MDPS = mg.GetDamage();
       }
    }
    class Fight_Evil : Fight
    {
        public Fight_Evil()
        {
            Gun g = new Gun();
            Sword s = new Sword();
            Evil e = new Evil(attack_speed: 200, damage: 200, health: 1000);
            Hero h = new Hero();
            HealthMonster = e.GetHealth();
            HealthHero = h.health;
            SDPS = s.DPS;
            GDPS = g.DPS;
            MDPS = e.GetDamage();
        }
    }
}
