using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Dialogues
    {
        public void BeginGame()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                      Добро пожаловать в World of elements");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                            Вы готовы начать игру?");
            Console.WriteLine("");
            Console.WriteLine("                              Введите Да или Нет");
            string choice = Convert.ToString(Console.ReadLine());
            if (choice == "Да" || choice == "да" || choice == "ДА")
            {
                Console.WriteLine("                          Тогда начнём приключение!");
                Console.ReadLine();
                Console.Clear();
            }
            else if (choice == "нет" || choice == "НЕТ" || choice == "Нет")
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                      Очень жаль, надеюсь мы ещё встретимся!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            { 
                Console.Clear();
                Console.WriteLine("              Видимо, у тебя IQ = 0,5. Эта игра явно не для тебя...");
                Console.ReadLine();
                Environment.Exit(0);
            }
            
        }
        
        public void Chapter1()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("                               Странный мир");
            //Console.ReadLine();
            //Console.WriteLine("....................................");
            //Console.ReadLine();
            //Console.WriteLine("Холодно...");
            //Console.ReadLine();
            //Console.WriteLine("Чертовски холодно.");
            //Console.ReadLine();
            //Console.WriteLine("Голова расскалывается...");
            //Console.ReadLine();
            //Console.WriteLine("Надо открыть глаза.");
            //Console.ReadLine();
            //Console.WriteLine("Взор озарило ночное небо.");
            //Console.ReadLine();
            //Console.WriteLine("Тысячи белых точек начали выжигать глаза, но боль была секундная.");
            //Console.ReadLine();
            //Console.WriteLine("И уж точно, эта боль не сравнится с головной.");
            //Console.ReadLine();
            //Console.WriteLine("Через пару минут я уже привык.");
            //Console.ReadLine();
            //Console.WriteLine("Что же произошло?. Ни черта не помню...");
            //Console.ReadLine();
            //Console.WriteLine("Я попытался встать. Всё тело заныло, но было вполне терпимо.");
            //Console.ReadLine();
            //Console.WriteLine("Чувство некоего дежавю, как будто не впервый раз себя так чувствую.");
            //Console.ReadLine();
            //Console.WriteLine("А ещё чувство, что с чего-то свалился.");
            //Console.ReadLine();
            //Console.WriteLine("Кажется мне, вид мой оставляет желать лучшего.");
            //Console.ReadLine();
            //Console.WriteLine("На мне надета кожаная броня, в полне себе целая.");
            //Console.ReadLine();
            //Console.WriteLine("На нагруднике маленькая эмблема чёрного дракона");
            //Console.ReadLine();
            //Console.WriteLine("Что же это могло значить?");
            //Console.ReadLine();
            //Console.WriteLine("Осмотревшись, я понял, что лежал на прибрежной тропе, справа река без края, слева лес темнющий.");
            //Console.ReadLine();
            //Console.WriteLine("Внезапно, из леса послышался треск.");
            //Console.ReadLine();
            //Console.WriteLine("- Кто здесь?!"); 
            //Console.ReadLine();
            //Console.WriteLine("Ответом послужил повторный хруст");
            //Console.ReadLine();
            //Console.WriteLine("- Эй, выходи кто бы ты ни был!");
            //Console.ReadLine();
            //Console.WriteLine("Начал выглядывать чёрный силуэт, но постепенно он начал приобретать отчётливые черты");
            //Console.ReadLine();
            //Console.WriteLine("Зелёная кожа...");
            //Console.ReadLine();
            //Console.WriteLine("Клыки...");
            //Console.ReadLine();
            //Console.WriteLine("...Красные глаза");
            //Console.ReadLine();
            //Console.WriteLine(".............");
            //Console.ReadLine();
            //Console.WriteLine("- Твою ж мать");
            //Console.ReadLine();
            //Console.WriteLine("- Я говорил кто-бы ты ни был, а не хрен пойми кто");
            //Console.ReadLine();
            //Console.WriteLine(" Тварь всё приближалась и приближалась, настрой у неё видимо был рвать и метать");
            //Console.ReadLine();
            //Console.WriteLine("Я и так себя хреново чувствую, а тут ещё и драться надо");
            //Console.ReadLine();
            //Console.WriteLine("Голыми руками я его точно не завалю");
            //Console.ReadLine();
            Console.WriteLine("ГДЕ ТУТ ДРЫН КАКОЙ-НИБУДЬ?!");
            Console.ReadLine();
            Console.WriteLine("Рядом валялась заострённая палка в метр длинной");
            Console.ReadLine();
            Console.WriteLine("- Ну куда лучше, чем на кулаках бить рожи друг-другу");
            Console.ReadLine();
        }
        public void Chapter2()
        {
           

        }
    }
}
