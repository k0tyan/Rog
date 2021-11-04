using System;

namespace Rog
{
    class Program
    {
        static void Main(string[] args)
        {
            Fight_Ghoul fg = new Fight_Ghoul();
            fg.Battle();
            History h = new History();
            //h.Telling();
        }
    }
}
