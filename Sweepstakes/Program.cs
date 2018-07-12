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
            MarketingFirm newFirm = new MarketingFirm();
            newFirm.GetSweepstakesName();
            newFirm.SelectManager();
            newFirm.CreateSweepstakes();
            newFirm.GetSweepstakes();


        }
    }
}
