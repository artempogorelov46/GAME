using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Fights
    {
        public void FightWithBeast(double playerhealth, double monsterhealth, double playerdamage, double monsterdamage)
        
        {
            Console.WriteLine("");
            Console.WriteLine("                  Бой с тварью начинается");
            Console.WriteLine("");
            double ph = playerhealth;
            double mh = monsterhealth;
            double pd = playerdamage;
            double md = monsterdamage;
            while (ph > 0 && mh > 0)
            {
                ph = ph - md;
                Console.WriteLine($"Тварь наносит удар - {md} урона");
                Console.WriteLine("");
                Console.WriteLine($"Ваш уровень здоровья - {ph}");
                Console.WriteLine("");
                mh = mh - pd;
                Console.WriteLine($"Вы наносите удар - {pd}");
                Console.WriteLine("");
                Console.WriteLine($"Уровень здоровья твари - {mh}");
                Console.WriteLine("");
                Console.ReadLine();
              
            }
            if (mh <= 20)
            {

                Console.WriteLine("");
                Console.WriteLine("Я настолько сильно начал под конец хреначить палкой, что в какой-то момент снёс твари бошку.");
                Console.ReadLine();
            }
            else if (ph <= 20)
            {

                Console.Clear();
                Death();
            }



        }
        public void Death()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                           Вы мертвы");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
