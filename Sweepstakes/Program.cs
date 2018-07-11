using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweepstakes s = new Sweepstakes("pack");
            Contestant c = new Contestant();
            Contestant a = new Contestant();
            Contestant b = new Contestant();

            s.RegisterContestant(a);
            s.RegisterContestant(b);
            s.RegisterContestant(c);
            s.PrintContestantInfo(c);
            Console.ReadLine();

        }
    }
}
