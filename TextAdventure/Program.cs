using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFileFolder = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TextFiles");

            #region WelcomeInitialize

            string[] welcome = File.ReadAllLines(textFileFolder + @"\Welcome.txt");
            ConsoleColor c = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), welcome[0]);
            Console.ForegroundColor = c;
            foreach (string line in welcome.Skip(1))
            {
                Console.WriteLine(line);
            }
            Console.ResetColor();
            PlayerStats newPlayer = new PlayerStats(Console.ReadLine(), 100, null);


            #endregion

            Console.Write("Welcome ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(newPlayer.Name + "!");
            Console.ResetColor();
            Console.WriteLine("Your health is: " + newPlayer.Health);
            Console.WriteLine("Your items are: " + newPlayer.Items);
            Console.ReadKey();
        }
    }
}
