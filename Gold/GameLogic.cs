using System;

namespace Gold
{
    public static class GameLogic
    {
        private static int _gold = 0;
        private static int _health = 100;
        public static string _playerName;

        public static void StartGame()
        {
            Console.Clear();
            _playerName = UserInteraction.GetPlayerName();
            Console.WriteLine($"Welcome, {_playerName}! Let the adventure begin!");

            while (_health > 0)
            {
                int choice = UserInteraction.GetActionChoice();

                switch (choice)
                {
                    case 1:
                        SearchForGold();
                        break;
                    case 2:
                        Rest();
                        break;
                    case 3:
                        Console.WriteLine("Exiting the game...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again");
                        break;
                }
            }

            Console.WriteLine("Game over! You ran out of health.");
        }

        private static void SearchForGold()
        {
            Random random = new Random();
            int goldFound = random.Next(10, 50);
            int damageTaken = random.Next(5, 15);

            _gold += goldFound;
            _health -= damageTaken;

            Console.WriteLine($"You found {goldFound} gold but took {damageTaken} damage.");
            DisplayStats();
        }

        private static void Rest()
        {
            _health = Math.Min(100, _health + 20);
            Console.WriteLine("You rested and regained health.");
            DisplayStats();
        }

        private static void DisplayStats()
        {
            Console.WriteLine($"\nPlayer: {_playerName}");
            Console.WriteLine($"Gold: {_gold}");
            Console.WriteLine($"Health: {_health}\n");
        }
    }
}