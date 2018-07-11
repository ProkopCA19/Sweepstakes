using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Managerfactory 
    {
      

        public ISweepstakesManager GetManager()
        {
            Console.WriteLine("Would you like to use a stack or a queue manager?");
            string manager = Console.ReadLine();
            switch (manager.ToLower())
            {
                case "stack":
                    return new SweepstakesStackManager();
                    
                case "queue":
                    return new SweepstakesQueueManager();
                    
                default:
                    Console.WriteLine("Not a valid option, try again");
                    return GetManager();
            }

        }



    }
}
