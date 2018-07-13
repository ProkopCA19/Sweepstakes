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

            Managerfactory newFactory = new Managerfactory();
            MarketingFirm newFirm = new MarketingFirm();
            newFirm.SelectManager();
            newFirm.MakeSweepstakes();
            newFirm.DoSweepstakes();
            Console.ReadLine();

        }
    }
}
