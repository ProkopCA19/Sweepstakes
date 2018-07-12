using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager manager;
        static string sweepstakesName;
        Sweepstakes newSweepstakes = new Sweepstakes(sweepstakesName);



        public ISweepstakesManager SelectManager()
        {
            Managerfactory mfactory = new Managerfactory();

            manager = mfactory.GetManager();
            return manager;
        }


        public string GetSweepstakesName()
        {
            Console.WriteLine("What would you like to name your sweepstakes?");
            sweepstakesName = Console.ReadLine();
            return sweepstakesName;
        }


        public void CreateSweepstakes()
        {
            manager.InsertSweepstakes(newSweepstakes);
        }


        public void GetSweepstakes()
        {
            manager.GetSweepStakes();
        }


        public Sweepstakes GenerateContestants(Sweepstakes newSweepstakes)
        {
            int numOfContestants;
            Console.WriteLine("how many contestants are in your sweepstakes?");
            numOfContestants = int.Parse(Console.ReadLine());

            for( int i = 0; i < numOfContestants; i++)
            {
                Contestant contestant = new Contestant();
                newSweepstakes.RegisterContestant(contestant);
            }
            return newSweepstakes;
        }

        public void PickWinner()
        {
            newSweepstakes.PickWinner();
        }


    }


}
