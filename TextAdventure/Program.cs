using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            PlayerStats newPlayer = new PlayerStats(Console.ReadLine(), 100, null);
            Console.Write("Welcome ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(newPlayer.Name);
            Console.ResetColor();
            Console.WriteLine("Your health is: " + newPlayer.Health);
            Console.WriteLine("Your items are: " + newPlayer.Items);
            Console.ReadKey();
        }
    }
}
