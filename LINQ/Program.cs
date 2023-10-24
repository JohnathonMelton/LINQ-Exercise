using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videogameNames = new List<string> {"Elder Scrolls Skyrim", "Ratchet and Clank", "Sly Cooper", "Jak and Daxter", "Final Fantasy", "Dragon Quest"};

            var orderedGames = videogameNames.OrderByDescending(name => name.Length);

            foreach (var videogameName in orderedGames)
            {
                Console.WriteLine(videogameName);
            }
        }
    }
}
