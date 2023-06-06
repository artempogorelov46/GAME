using System;
using System.Text;
namespace Game;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "World of elements";
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
        player.Level = 2;
        player.Damage += 100;
        player.Health += 200;
        Console.WriteLine($"Теперь ваш уровень равен: {player.Level}, ваше здоровье равно: {player.Health}, ваш урон равен: {player.Damage}.");
        Console.ReadLine();
        Console.WriteLine("Фух, было очень не просто"); // Это был пиздец 
        Console.ReadLine();
        Console.WriteLine($"- ЭЙ, {player.Name}");
        Console.ReadLine();
        dialogues.Chapter2();
        Console.ReadKey();
    }
}