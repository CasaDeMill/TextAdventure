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
            PlayerStats playerStats = new PlayerStats("Martin");
            Console.WriteLine(playerStats.Name);
            Console.ReadKey();
        }
    }
}
