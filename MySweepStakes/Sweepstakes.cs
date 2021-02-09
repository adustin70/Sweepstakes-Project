using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepStakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        public string Name { get; set; }
        int key = 0;

        public Sweepstakes(string name)
        {
            name = Name;
            contestants = new Dictionary<int, Contestant>();
        }

        void RegisterContestant(Contestant contestant)
        {
            if (contestants.Count == 0)
            {
                key++;
                contestants.Add(key, contestant);
                contestant.ContestantRegistrationNumber = key;
            }

            while (UserInterface.AskToEnterAnotherContestant() == true)
            {
                contestant.GetContestantInfo();
                key++;
                contestants.Add(key, contestant);
                contestant.ContestantRegistrationNumber = key;
            }
        }

        Contestant PickWinner()
        {
            Random randomKey = new Random();
            int key = randomKey.Next(contestants.Count);

            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (key == contestant.Key)
                    return contestant.Value;
            }
            return null;
        }

        void PrintContestantInfo(Contestant contestant)
        {
            contestant = PickWinner();
            foreach (KeyValuePair<int, Contestant> theContestant in contestants)
            {
                if (contestant == theContestant.Value)
                Console.WriteLine(theContestant.Key + "-" + contestant.ContestantLastName + "," + contestant.ContestantFirstName + "\n" + contestant.ContestantEmail);
            }
        }
    }
}
