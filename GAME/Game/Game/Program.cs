using System;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace Game;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Nord's World ";
        Dialogues dialogues = new Dialogues();
        dialogues.BeginGame();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("                      Введите имя персонажа");
        string name = Convert.ToString(Console.ReadLine());
        Console.Clear();
        Player player = new Player(name, 140, 1000);
        Monsters beast = new Monsters("Тварь", 120, 1120);
        Monsters harald = new Monsters("Харальд Молния", 190, 1600);
        Fights fights = new Fights();
        dialogues.Chapter1();
        fights.FightWithBeast(player.Health, beast.Health, player.Damage, beast.Damage);
        Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"- ЭЙ, {player.Name}");
        Console.ReadLine();
        dialogues.Chapter2();
        dialogues.Chapter3();
        var buf_armor = fights.Buf(player.Health, 350); 
        Console.WriteLine($"- Удачи, {player.Name}!");
        Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.White;
        fights.FightWithHarald(buf_armor, harald.Health, player.Damage, harald.Damage);
        var buf_damage = fights.Buf(player.Damage, 150);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("                  На этом пока всё!");
        Console.WriteLine("");
        Console.WriteLine("  Если хотите дать знать разроботчику, что вам понравилась игра" +
                        "поддержите его и напишите пару приятных слов ВКонтакте (id: artemidalife)");
        Console.ReadKey();
    }
}