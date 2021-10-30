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
        public Fight()
        {
            Gun g = new Gun();
            Sword s = new Sword();
            Monster m = new Monster();
            Hero h = new Hero();
            HealthMonster = m.health;
            HealthHero = h.health;
            SDPS = s.DPS;
            GDPS = g.DPS;
            MDPS = m.DPS;
        }
        public void Battle()
        {
           
            int couldown = 0;
            Console.WriteLine("Вы встретили монстра выберите оружие,которым будете сражаться. 1 - пистолет, 2 - меч");
            while (HealthHero > 0 || HealthMonster > 0)
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
                if (HealthMonster <= 0) { Console.WriteLine("Монстр побежден"); Environment.Exit(0); }
                else if (HealthHero <= 0) { Console.WriteLine("Герой пал"); Environment.Exit(0); }
            }
        }
    }
}
