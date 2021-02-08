using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepStakes
{
    class IContestant
    {
        public static string GetFirstName()
        {
            string userInput;
            Console.WriteLine("Please enter your first name");
            userInput = Console.ReadLine();
            return userInput;
        }

        public static string GetLastName()
        {
            string userInput;
            Console.WriteLine("Please enter your last name");
            userInput = Console.ReadLine();
            return userInput;
        }

        public static string GetUserEmail()
        {
            string userInput;
            Console.WriteLine("Please enter your email");
            userInput = Console.ReadLine();
            return userInput;
        }

        public static int GetRegistrationNumber()
        {
            int userInput;
            Console.WriteLine("Please enter your resgistration number");
            userInput = Int32.Parse(Console.ReadLine());
            return userInput;
        }
    }
}
