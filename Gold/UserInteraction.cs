using System;

namespace Gold
{
    public static class UserInteraction
    {
        public static string GetPlayerName()
        {
            Console.Write("Enter your player name: ");
            return Console.ReadLine();
        }

        public static int GetActionChoice()
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Search for Gold");
            Console.WriteLine("2. Rest");
            Console.WriteLine("3. Quit Game");
            Console.Write("Your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                return choice;
            }

            return -1;
        }
    }
}