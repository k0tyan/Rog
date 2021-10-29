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
            Inventory i = new Inventory();
            Fight f = new Fight();
            //Console.WriteLine("Чтоб открыть инвертарь нажмите 3");
            //string c = Console.ReadLine();
            f.Battle();


            //if (c == "3")
            //{
            //    i.GetItem();
            //}
        }
    }
}
