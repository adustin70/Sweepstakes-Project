using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepStakes
{
    public static class UserInterface
    {
        static string userInput;

        public static string GetFirstName()
        {
            Console.WriteLine("Please enter your first name");
            userInput = Console.ReadLine();
            return userInput;
        }

        public static string GetLastName()
        {
            Console.WriteLine("Please enter your last name");
            userInput = Console.ReadLine();
            return userInput;
        }

        public static string GetUserEmail()
        {
            Console.WriteLine("Please enter your email");
            userInput = Console.ReadLine();
            return userInput;
        }

        public static bool AskToEnterAnotherContestant()
        {
            Console.WriteLine("Would you like to enter another contestant?");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "y":
                case "yes":
                    return true;
                case "n":
                case "no":
                    return false;
                default:
                    Console.WriteLine("Invalid input");
                    return AskToEnterAnotherContestant();
            }
        }

        public static bool AskForStackOrQueue()
        {
            Console.WriteLine("Would you like a Stack or Queue to manage your sweepstakes objects?\n");
            Console.WriteLine("Please enter Stack or Queue:");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "stack":
                    return true;
                case "queue":
                    return true;
                default:
                    Console.WriteLine("Invalid input");
                    return AskForStackOrQueue();
            }
        }
    }
}
