using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepStakes
{
    public class Contestant
    {
        public string ContestantFirstName 
        {
            get { return ContestantFirstName; }
            set { ContestantFirstName = UserInterface.GetUserInformation("Please enter your first name"); } 
        }
        public string ContestantLastName
        {
            get { return ContestantLastName; }
            set { ContestantLastName = UserInterface.GetUserInformation("Please enter you last name"); }
        }
        public string ContestantEmail 
        {
            get { return ContestantEmail; }
            set { ContestantEmail = UserInterface.GetUserInformation("Please enter you Email address"); }
        }
        public int ContestantRegistrationNumber { get; set; }
    }
}
