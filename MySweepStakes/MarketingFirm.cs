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
            contestant.GetContestantInfo();

            Sweepstakes sweepstakes = new Sweepstakes(contestant.ContestantFirstName);
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.PickWinner();
            sweepstakes.PrintContestantInfo(contestant);
        }
    }
}
