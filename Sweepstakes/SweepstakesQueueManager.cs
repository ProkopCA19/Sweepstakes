using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> myQueue = new Queue<Sweepstakes>();


        public SweepstakesQueueManager()
        {
            myQueue = new Queue<Sweepstakes>();
        }

        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {
            myQueue.Enqueue(sweepstakes);
        }


        Sweepstakes ISweepstakesManager.GetSweepStakes()
        {
           return myQueue.Dequeue();
        }

        
    }
}
