using System;
using System.Collections.Generic;

namespace Gold
{
    public static class Utilities
    {
        private static List<string> _scoreboard = new List<string>();

        public static void AddToScoreboard(string playerName, int score)
        {
            _scoreboard.Add($"{playerName}: {score} gold");
        }

        public static void DisplayScoreboard()
        {
            Console.Clear();
            Console.WriteLine("==== SCOREBOARD ====");

            if (_scoreboard.Count == 0)
            {
                Console.WriteLine("No scores yet!");
            }
            else
            {
                foreach (var entry in _scoreboard)
                {
                    Console.WriteLine(entry);
                }
            }
        }
    }
}