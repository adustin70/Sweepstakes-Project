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
            SweepstakesQueueManager manager = new SweepstakesQueueManager();
            MarketingFirm marketingFirm = new MarketingFirm(manager);
            marketingFirm.CreateSweepstakes();
        }
    }
}
