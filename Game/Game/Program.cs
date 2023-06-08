using System;
using System.Text;
namespace Game;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Nord's World ";
        Dialogues dialogues = new Dialogues();
        dialogues.BeginGame();
        Fights fights = new Fights();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("                      Введите имя персонажа");
        string name = Convert.ToString(Console.ReadLine());
        Console.Clear();
        Player player = new Player(name,1,140,1000);
        Monsters monster = new Monsters("Тварь", 1, 120, 1120); 
   
        dialogues.Chapter1();
        fights.FightWithBeast(player.Health, monster.Health, player.Damage, monster.Damage);
        fights.LevelUp(player.Level, player.Damage, player.Health);
        Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"- ЭЙ, {player.Name}");
        Console.ReadLine();
        dialogues.Chapter2();
        dialogues.Chapter3();
        Console.WriteLine($"- Удачи, {player.Name}!");
        Console.ReadKey();
    }
}