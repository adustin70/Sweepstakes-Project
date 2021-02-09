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
        }

        public void CreateSweepstakes()
        {
            Contestant contestant = new Contestant();
            Sweepstakes sweepstakes = new Sweepstakes("Your Sweepstakes name");
            contestant.GetContestantInfo();
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.PrintContestantInfo(contestant);
        }
    }
}
