using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> myStack = new Stack<Sweepstakes>();

 
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            myStack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepStakes()
        {
           return myStack.Pop();
        }


    }
}
