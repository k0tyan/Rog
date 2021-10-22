using System;

namespace Rog
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun g = new Gun();
            Sword s = new Sword();
            Monster m = new Monster();
            int health = 100;
            //s.GetInfo();
            //m.GetInfo();
            do
            {
                health -= g.DPS;
                g.GetInfo(health);

            }
            while (health > 0);
            Console.WriteLine("Монстр побежден");
        }
    }
}
