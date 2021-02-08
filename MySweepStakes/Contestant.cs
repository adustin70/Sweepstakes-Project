using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepStakes
{
    class Contestant
    {
        public string ContestantFirstName { get; set; }
        public string ContestantLastName { get; set; }
        public string ContestantEmail { get; set; }
        public int ContestantRegistrationNumber { get; set; }

        public void GetContestantInfo()
        {
            ContestantFirstName = IContestant.GetFirstName();
            ContestantLastName = IContestant.GetLastName();
            ContestantEmail = IContestant.GetUserEmail();
            ContestantRegistrationNumber = IContestant.GetRegistrationNumber();
        }
    }
}
