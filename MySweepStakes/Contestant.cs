using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepStakes
{
    public class Contestant
    {
        public string ContestantFirstName { get; set; }
        public string ContestantLastName { get; set; }
        public string ContestantEmail { get; set; }
        public int ContestantRegistrationNumber { get; set; }

        public void GetContestantInfo()
        {
            ContestantFirstName = UserInterface.GetFirstName();
            ContestantLastName = UserInterface.GetLastName();
            ContestantEmail = UserInterface.GetUserEmail();
        }
    }
}
