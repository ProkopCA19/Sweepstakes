using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {

        public static string GetContestantFirstName()
        {
            Console.WriteLine("Please enter their first name");
            return Console.ReadLine();

        }

        public static string GetContestantLastName()
        {
            Console.WriteLine("Please enter their last name");
            return Console.ReadLine();
        }

        public static string GetContestantEmail()
        {
            Console.WriteLine("Please enter their email address");
            return Console.ReadLine();
        }

        public static string GetNameofSweepstakes()
        {
            Console.WriteLine("What would you like to name your sweepstakes?");
            string sweepstakesName = Console.ReadLine();
            return sweepstakesName;
        }

        public static int GetNumOfContestants(Sweepstakes sweepstakes)
        {
                Console.WriteLine("How many contestants would you like to add?");
                int newContestants = Int32.Parse(Console.ReadLine());
                return newContestants;
        }

    }
}
