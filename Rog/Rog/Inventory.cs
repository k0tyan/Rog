using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rog
{
    class Inventory
    {
        public void GetItem()
        {

            Gun g = new Gun();
            Sword s = new Sword();
            Console.WriteLine("О каком оружии вы хотите узнать информацию: 1- пистолет или 2 - меч?");
            string c = Console.ReadLine();
                switch (c)
                {
                    case "1":
                        g.GetInfo();
                        break;
                    case "2":
                        s.GetInfo();
                        break;
                }
            
        }

    }
}
