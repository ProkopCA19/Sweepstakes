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
     

        public MarketingFirm()
        {
        }


        public ISweepstakesManager SelectManager()
        {
            Managerfactory mfactory = new Managerfactory();
            manager = mfactory.GetManager();
            return manager;
        }


        public void CreateSweepstakes(Sweepstakes sweepstakes)
        {
            manager.InsertSweepstakes(sweepstakes);
        }


        public Sweepstakes GetSweepstakes()
        {
           return manager.GetSweepStakes();
            
        }


        public void MakeSweepstakes()
        {
            string sweepstakesName = UserInterface.GetNameofSweepstakes();
            Sweepstakes newSweep = new Sweepstakes(sweepstakesName);
            CreateSweepstakes(newSweep);
        }





        public void DoSweepstakes()
        {
            Sweepstakes newSweepstakes = GetSweepstakes();
            int newContestants = UserInterface.GetNumOfContestants(newSweepstakes);
            for (int i = 0; i < newContestants; i++)
            {
                Contestant newContestant = new Contestant();
                newSweepstakes.RegisterContestant(newContestant);
            }
            newSweepstakes.PickWinner();
            Console.WriteLine("The winner is " + newSweepstakes.PickWinner());
            
        }

    }

   

}
