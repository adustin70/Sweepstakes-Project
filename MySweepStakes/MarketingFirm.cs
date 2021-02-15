using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepStakes
{
    class MarketingFirm
    {
        ISweepstakesManager _manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this._manager = manager;
        }// I'm using constructor dependency injection here so that you can pass in the object needed in this case Stack or Queue
        // This allows for more flexability as well as easier testing

        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes("Yor sweepstakes name");
        }
    }
}
