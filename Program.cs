using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myGames = new List<string>() { "Space Invaders", "Pac-Man", "Pit Fall", "Mario" };

            var sorted = myGames.OrderBy(x => x);

            myGames.Sort();

            foreach(var game in sorted)
            {

                Console.WriteLine(game);
            }




            















        }
    }
}
