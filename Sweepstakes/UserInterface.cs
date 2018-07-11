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
            Console.WriteLine("Please enter your first name");
            return Console.ReadLine();

        }

        public static string GetContestantLastName()
        {
            Console.WriteLine("Please enter your last name");
            return Console.ReadLine();
        }

        public static string GetContestantEmail()
        {
            Console.WriteLine("Please enter your email address");
            return Console.ReadLine();
        }

    }
}
