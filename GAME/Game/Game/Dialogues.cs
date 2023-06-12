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
            Console.WriteLine("                      Добро пожаловать в Nord's World");
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("                              Глава 1. Бурное пробуждение");
            Console.WriteLine("");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
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
            Console.WriteLine("Как звать существо я не знаю, в голову лезло только одно слово");
            Console.ReadLine();
            Console.WriteLine("Тварь...");
            Console.ReadLine();
        }
        public void Chapter2()
        {
           
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("                             Глава 2. Повесть о том, почему я мудак");
            Console.WriteLine("");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("На тропинке показался мужчина средних лет, в такой же броне с символом дракона, что и я");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("- Эй, кретин! Дуй сюда!");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Бежать было больно, тварь меня знатно потрепала.");
            Console.ReadLine();
            Console.WriteLine("Кое как доковыляв до мужика, у нас завязался диалог.");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("- Придурок... ТЫ ГДЕ БЫЛ ВСЁ ЭТО ВРЕМЯ?!?!?!?");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("- Эээ, мы знакомы?");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("- Ты щас прикалываешься? Совсем медовуха мозги отшибла?");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("- Не думаю, что понимаю, о чём ты....");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("- Ох, ясно всё с тобой");
            Console.ReadLine();
            Console.WriteLine("Тогда щас буду тебе рассказывать что произошло, и почему ты мудак.");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("- Э... У... Ну давай");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("- Меня звать Магнус Железнобок, я командир отряда Драконий Клык.");
            Console.ReadLine();
            Console.WriteLine("Мы с тобой 2 солдата Короля Рагнара Драконборца");
            Console.ReadLine();
            Console.WriteLine("Неделю назад мы поймали отряд, возглавляемый главным противником нашего величества.");
            Console.ReadLine();
            Console.WriteLine("Сегодня должны были их вести в Драгонград на казнь");
            Console.ReadLine();
            Console.WriteLine("Но за эту неделю на радостях, что поймали таких важных пленных, наш отряд пил не просыхая");
            Console.ReadLine();
            Console.WriteLine("И ты, жертва спирта, в первую очередь!");
            Console.ReadLine();
            Console.WriteLine("Ты, пьяная рожа, вчера так шатался, что споткнулся, упал на лошадь, а та, в свою очередь....");
            Console.ReadLine();
            Console.WriteLine("СНЕСЛА НАХЕР ТЕЛЕГУ С ПЛЕННЫМИ!!!");
            Console.ReadLine();
            Console.WriteLine("Пленники как-то выбрались из клеток и порешали так весь наш отряд.");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Я сглотнул, осозновая что натворил.");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Сильные ублюдки, не зря на их охрану отряд понадобился");
            Console.ReadLine();
            Console.WriteLine("Но всё же большую часть убил их лидер, Торгель Безумный...");
            Console.ReadLine();
            Console.WriteLine("- Может скажешь что-нибудь, кретин?");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("- Я.... я....");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Хер с тобой, слушай теперь сюда!");
            Console.ReadLine();
            Console.WriteLine("Кроме нас двоих никого не осталось, но я должен донести Рагнару об этом");
            Console.ReadLine();
            Console.WriteLine("Так что всю кашу, как провинившему, предлагаю расхлёбывать тебе");
            Console.ReadLine();
            Console.WriteLine("Если конечно бошка твоя тебе дорога");
            Console.ReadLine();
            Console.WriteLine("Вижу тварь эту ты завалил, но с ней и молокосос справился бы");
            Console.ReadLine();
            Console.WriteLine("В отряде было ещё трое, включая лидера, и с ними всё не так легко.");
            Console.ReadLine();
            Console.WriteLine("Я дам тебе карту в этой местности есть трое мастеров.");
            Console.ReadLine();
            Console.WriteLine("Каждый научит тебя тому, что поможет в бою с врагами");
            Console.ReadLine();
            Console.WriteLine("Каждый из врагов сильнее другого, у каждого есть определённое количество здоровья и урона");
            Console.ReadLine();
            Console.WriteLine("И у тебя они есть, и ты можешь чувствовать чужие. Такова сила нашего клана, служащего королю");
            Console.ReadLine();
            Console.WriteLine("Пока у тебя эти значения маленькие, как и твой мозг. Поэтому начинай с Морозного Хребта.");
            Console.ReadLine();
            Console.WriteLine("Там встретишь Браума Бородатого, он тебе поможет, и так дальше пойдёшь по карте");
            Console.ReadLine();
            Console.WriteLine("А теперь дуй отсюда, солдат! И выполнять приказ!");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Слушаюсь! - Вырвалось у меня сразу же.");
            Console.ReadLine();
            Console.WriteLine("Всё же Магнус... мужик, умеющий внушать. ");
            Console.ReadLine();
            Console.WriteLine("Ох, в какой же заднице я оказался....");
            Console.ReadLine();
        }
        public void Chapter3()
        {
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("                             Глава 3. Исскусство меча");
            Console.WriteLine("");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("С горем пополам к утру я добрался до лачуги, в которой жил Браум Бородатый");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("- Эй, путник. Чего ищешь?");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Браум Бородатый был огромным мужчиной ростом метра 2, и бородой до колен");
            Console.ReadLine();
            Console.WriteLine("- Здравствуйте, меня послал к вам Магнус Железнобок");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("- О, старина Магнус! Как он там? Пойдём в лачугу расскажешь");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Зайдя в лачугу, я рассказал всё что, со мной произошло с момента пробуждения");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("- Мда, ну ты и мудак");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("- Уже слышал за сегодня");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("И вполне справедливо, но делать нечего, раз тебе доверили такое задание, то придётся тебе помочь");
            Console.ReadLine();
            Console.WriteLine("Тебе предстоит сразиться с Харальдом Молнией, звать его так, потому что очень быстро орудует мечом");
            Console.ReadLine();
            Console.WriteLine("Для сражения с ним тебе предстоить познать искусство меча в кратчайшие сроки.");
            Console.ReadLine();
            Console.WriteLine("Вот, что ты можешь делать в бою");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 1 - Обычный удар");
            Console.WriteLine(" 2 - Удар плашмя");
            Console.WriteLine(" 3 - Выпад");
            Console.WriteLine(" 4 - Блок");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("С мечом ты нанесёшь урона больше чем кулаком");
            Console.ReadLine();
            Console.WriteLine("Но это если ты попадёшь, поэтому надо читать врага и понимать когда он ударит, а когда заблокирует");
            Console.ReadLine();
            Console.WriteLine("В этом тебе поможет твоё драконье чувство.");
            Console.ReadLine();
            Console.WriteLine("Только будь осторожнее! Если во время того как он блокирует, у тебя не получится удар, его удар будет больше в зависимости от того, какой удар хотел нанести ты");
            Console.ReadLine();
            Console.WriteLine("Вот возьми, пригодится.");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Получены меч и лёгкие латы: + 350 количества здоровья");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Этого должно хватить, чтобы хотя бы не умереть");
            Console.ReadLine();
        }
    }
}
