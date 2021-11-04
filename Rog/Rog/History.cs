using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rog
{
    class History
    {
        public void Telling()
        {
            Sword s = new Sword();
            Fight f = new Fight();
            Console.WriteLine("Вставай,путник,ты нужен этому миру. Ты должен его спасти!\n" +
                "Вы приходите в себя и видите лишь темноту и факел. Перед вами лежит меч возьмете его?");
            string c = Console.ReadLine();
            switch (c)
            {
                case "да":
                    Console.WriteLine("Вы подбираете меч и вот его характеристики:");
                    s.GetInfo();
                    Console.WriteLine("Вы находите факел и подбираете его и идете вглубь пещеры где натыкаетесь на монстра" +
                        "Но прежде чем атаковать вы находиете пистолет и берете его." +
                        "Удачи в сражении!");
                    f.Battle();

                    break;
                case "нет":
                    //написать развилку
                    break;
                default:
                    Console.WriteLine("Неверный вариант. Вы умерли\n" +
                        "Начните заново и следуйте правилам!");
                    break;
            }
        }
        public void Next()
        {
            Console.WriteLine("Поздравляю с победой. Но дальше тебя ждут более опасные враги и только ты сможешь спасти мир." +
                "Тебе надо победить владыку,который находится в этой пещере. Это твой шанс пойти и оделеть его и закончить с ним раз и навсегда\n" +
                "Странный голос все говорл и говорил,а главный герой не понимал что же ему делать дальше. Так что же ты выберешь отправиться к владыки зла или" +
                "Найти выход из пещеры?\n(Чтоб пойти к владыке напиши отправиться,а чтоб найти выход напиши выход)");
            string ans = Console.ReadLine();
            switch (ans)
            {
                case "отправиться":
                    break;
                case "выход":
                    break;
            }
        }

    }
}
