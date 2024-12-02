using System;

namespace Gold
{
    public static class Menu
    {
        public static void DisplayMainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== GOLD ADVENTURE ====");
                Console.WriteLine("1. Start Game");
                Console.WriteLine("2. View Scoreboard");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GameLogic.StartGame();
                        break;
                    case "2":
                        Utilities.DisplayScoreboard();
                        break;
                    case "3":
                        Console.WriteLine("Thanks for playing!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}