using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Game
{
    internal class Fights
    {
        public void FightWithBeast(double playerhealth, double monsterhealth, double playerdamage, double monsterdamage)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("                  Бой с тварью начинается");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
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
        public void FightWithHarald(double playerhealth, double monsterhealth, double playerdamage, double monsterdamage)
        {
            Console.WriteLine("Выйдя из хижины Браума долго ждать не пришлось.");
            Console.ReadLine();
            Console.WriteLine("Тут же объявился Харальд. В этот раз я его не упущу...");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("                  Бой с Харальдом Молнией начинается");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;

            double ph = playerhealth;
            double mh = monsterhealth;
            double pd = playerdamage;
            double md = monsterdamage;
            Random rnd_damage = new Random();
           
           
            while (ph > 0 && mh > 0)
            {
                int rnd_pd_ydar = rnd_damage.Next(1, 2); // обычный
                int rnd_pd_plashma = rnd_damage.Next(1, 5); //плашмя
                int rnd_pd_vipad = rnd_damage.Next(1, 8); // выпад
                int rnd_pd_block = rnd_damage.Next(1, 5); // блок

                int rnd_harald_atack = rnd_damage.Next(1, 5); // атака Харальда

                Console.WriteLine("Выберите атаку");
                Console.WriteLine(" 1 - Обычный удар + (20 - 30 урона)");
                Console.WriteLine(" 2 - Удар плашмя + (50 - 75 урона)");
                Console.WriteLine(" 3 - Выпад + (100 - 150 урона)");
                Console.WriteLine(" 4 - Блок (половина полученного урона)");
                int choice_damage = Convert.ToInt32(Console.ReadLine());
                switch (choice_damage)
                {
                    case 1: 
                        if (rnd_harald_atack >= 1 && rnd_harald_atack <= 2)
                        {
                            Console.WriteLine("Харальд атакует!");
                            Console.WriteLine("");
                            if (rnd_pd_ydar == 1 ) // удачно
                            {
                                pd += 20;
                                mh -= pd;
                                Console.WriteLine($"Вы нанесли Обычный удар Харальду - {pd} урона");
                                Console.WriteLine($"Здоровье Харальда: {mh}");
                                Console.WriteLine($"Ваше здоровье: {ph}");
                                pd -= 20;
                                Console.ReadLine();
                            }
                            else if (rnd_pd_ydar == 2) //не удачно
                            {
                                ph -= md;
                                Console.WriteLine("Не получилось нанести обычный удар");
                                Console.WriteLine($"Харальд нанёс вам удар {md}");
                                Console.WriteLine($"Ваше здоровье: {ph}");
                                Console.WriteLine($"Здоровье Харальда: {mh}");
                                Console.ReadLine();
                            }
                        }
                        else if (rnd_harald_atack >= 3)
                        {
                            Console.WriteLine("Харальд блокирует");
                            Console.WriteLine("");
                            if (rnd_pd_ydar == 1) // удачно
                            {
                                pd += 30;
                                mh -= pd;
                                Console.WriteLine($"Вы нанесли Обычный удар Харальду - {pd} урона");
                                Console.WriteLine($"Здоровье Харальда: {mh}");
                                Console.WriteLine($"Ваше здоровье: {ph}");
                                pd -= 30;
                                Console.ReadLine();
                            }
                            else if (rnd_pd_ydar == 2) //не удачно
                            {
                                ph -= (md + 20);
                                Console.WriteLine("Не получилось нанести обычный удар");
                                Console.WriteLine($"Харальд нанёс вам удар {md + 20}");
                                Console.WriteLine($"Ваше здоровье: {ph}");
                                Console.WriteLine($"Здоровье Харальда: {mh}");
                                Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        if (rnd_harald_atack >= 1 && rnd_harald_atack <= 2)
                        {
                            Console.WriteLine("Харальд атакует!");
                            Console.WriteLine("");
                            if (rnd_pd_plashma == 1) // удачно
                            {
                                pd += 50;
                                mh -= pd;
                                Console.WriteLine($"Вы нанесли удар плашмя Харальду - {pd} урона");
                                Console.WriteLine($"Здоровье Харальда: {mh}");
                                Console.WriteLine($"Ваше здоровье: {ph}");
                                pd -= 50;
                                Console.ReadLine();
                            }
                            else if (rnd_pd_plashma == 2) //не удачно
                            {
                                ph -= md;
                                Console.WriteLine("Не получилось нанести удар плашмя");
                                Console.WriteLine($"Харальд нанёс вам удар {md}");
                                Console.WriteLine($"Ваше здоровье: {ph}");
                                Console.WriteLine($"Здоровье Харальда: {mh}");
                                Console.ReadLine();
                            }
                        }
                        else if (rnd_harald_atack >= 3)
                        {
                            Console.WriteLine("Харальд блокирует");
                            Console.WriteLine("");
                            if (rnd_pd_plashma == 1) // удачно
                            {
                                pd += 75;
                                mh -= pd;
                                Console.WriteLine($"Вы нанесли удар плашмя Харальду - {pd} урона");
                                Console.WriteLine($"Здоровье Харальда: {mh}");
                                Console.WriteLine($"Ваше здоровье: {ph}");
                                pd -= 75;
                                Console.ReadLine();
                            }
                            else if (rnd_pd_plashma == 2) //не удачно
                            {
                                ph -= (md + 75);
                                Console.WriteLine("Не получилось нанести удар плашмя");
                                Console.WriteLine($"Харальд нанёс вам удар {md + 75}");
                                Console.WriteLine($"Ваше здоровье: {ph }");
                                Console.WriteLine($"Здоровье Харальда: {mh}");
                                Console.ReadLine();
                            }
                        }
                        break;
                    case 3:
                        if (rnd_harald_atack >= 1 && rnd_harald_atack <= 2)
                        {
                            Console.WriteLine("Харальд атакует!");
                            Console.WriteLine("");
                            if (rnd_pd_vipad == 1) // удачно
                            {
                                pd += 100;
                                mh -= pd;
                                Console.WriteLine($"Вы совершили выпад и нанесли Харальду - {pd} урона");
                                Console.WriteLine($"Ваше здоровье: {ph}");
                                Console.WriteLine($"Здоровье Харальда: {mh}");
                                pd -= 100;
                                Console.ReadLine();
                            }
                            else if (rnd_pd_vipad >= 2 && rnd_pd_vipad <= 6) //не удачно
                            {
                                ph -= md;
                                Console.WriteLine("Не получилось совершить выпад");
                                Console.WriteLine($"Харальд нанёс вам удар {md}");
                                Console.WriteLine($"Ваше здоровье: {ph}");
                                Console.WriteLine($"Здоровье Харальда: {mh}");
                                Console.ReadLine();
                            }
                        }
                        else if (rnd_harald_atack >= 3)
                        {
                            Console.WriteLine("Харальд блокирует");
                            Console.WriteLine("");
                            if (rnd_pd_vipad == 1) // удачно
                            {
                                pd += 150;
                                mh -= pd;
                                Console.WriteLine($"Вы совершили выпад и нанесли Харальду - {pd} урона");
                                Console.WriteLine($"Ваше здоровье: {ph}");
                                Console.WriteLine($"Здоровье Харальда: {mh}");
                                pd -= 150;
                                Console.ReadLine();
                            }
                            else if (rnd_pd_vipad >= 2 && rnd_pd_vipad <= 6) //не удачно
                            {
                                ph -= (md + 150);
                                Console.WriteLine("Не получилось совершить выпад");
                                Console.WriteLine($"Харальд нанёс вам удар {md + 150}");
                                Console.WriteLine($"Ваше здоровье: {ph}");
                                Console.WriteLine($"Здоровье Харальда: {mh}");
                                Console.ReadLine();
                            }
                        }
                        break;
                    case 4:
                        if (rnd_harald_atack >= 1 && rnd_harald_atack <= 2)
                        {
                            Console.WriteLine("Харальд атакует!");
                            Console.WriteLine("");
                            if (rnd_pd_block >= 1 && rnd_pd_block <= 4) // удачно
                            {
                                md = md / 2;
                                ph -= md;
                                Console.WriteLine($"Вы поставили блок - и получили {md} урона");
                                Console.WriteLine($"Ваше здоровье: {ph}");
                                Console.WriteLine($"Здоровье Харальда: {mh}");
                                md = md * 2;
                                Console.ReadLine();
                            }
                            else if (rnd_pd_block == 5) // не удачно
                            {
                                ph -= md;
                                Console.WriteLine($"Вы не успели поставить блок - и получили {md} урона");
                                Console.WriteLine($"Ваше здоровье: {ph}");
                                Console.WriteLine($"Здоровье Харальда: {mh}");
                                Console.ReadLine();
                            }
                        }
                        else if (rnd_harald_atack >= 3)
                        {
                            Console.WriteLine("Харальд блокирует!");
                            Console.WriteLine("");
                            Console.WriteLine("Смысла ставить блок нет, надо нападать!");
                            Console.ReadLine();
                        }
                        break;
                }
            }
            if (mh <= 20)
            {
                Console.WriteLine("");
                Console.WriteLine("Харальд бился как безумец, настоящий мастер меча");
                Console.ReadLine();
                Console.WriteLine("Но удача была на моей стороне, и мой меч оборвал его жизнь");
                Console.ReadLine();
                Console.WriteLine("Меч у него красивый, он мне понадобится");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Вы получили меч 'Молния', теперь ваш урон равен {pd + 150}");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (ph <= 20)
            {
                Console.Clear();
                Death();
            }
        }
        
        public double Buf (double haracteristic, double buf)
        {
            return haracteristic + buf;
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
