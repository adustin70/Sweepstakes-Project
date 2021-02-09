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
        {// I used method dependency injection here so that based off of user input it will set the manager to be used and pass it into MarketingFirm
        //  Which will create a new instance of MarketingFirm with eiter a Stack or Queue manager
            if (UserInterface.AskForStackOrQueue() == true)
            {
                ISweepstakesManager manager = new SweepstakesStackManager();
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
