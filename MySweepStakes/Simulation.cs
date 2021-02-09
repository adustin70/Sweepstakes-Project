using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepStakes
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            if (UserInterface.AskForStackOrQueue() == true)
            {
                ISweepstakesManager manager = new SweepstakeStackManager();
                MarketingFirm marketingFirm = new MarketingFirm(manager);
                marketingFirm.CreateSweepstakes();
            }
            else if (UserInterface.AskForStackOrQueue() == false)
            {
                ISweepstakesManager manager = new SweepstakesQueueManager();
                MarketingFirm marketingFirm = new MarketingFirm(manager);
                marketingFirm.CreateSweepstakes();
            }
        }
    }
}
