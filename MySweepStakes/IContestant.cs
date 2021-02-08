using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepStakes
{
    class IContestant
    {
        public string ContestantFirstName { get; set; }
        public string ContestantLastName { get; set; }
        public string ContestantEmail { get; set; }
        public int ContestantRegistation { get; set; }

        public IContestant(string firstName, string lastName, string eMail, int registrationNumber)
        {
            this.ContestantFirstName = firstName;
            this.ContestantLastName = lastName;
            this.ContestantEmail = eMail;
            this.ContestantRegistation = registrationNumber;
        }


    }
}
