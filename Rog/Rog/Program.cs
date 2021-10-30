using System;

namespace Rog
{
    class Program
    {
        static void Main(string[] args)
        {
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
