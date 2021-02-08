using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepStakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        public string Name { get; set; }

        public Sweepstakes(string name)
        {
            name = Name;
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            for (int key = 0; key < contestants.Count; key++)
            {
                contestants.Add(key, contestant);
            }
        }

        public Contestant PickWinner()
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

        public void PrintContestantInfo(Contestant contestant)
        {
            foreach (KeyValuePair<int, Contestant> theContestant in contestants)
            {
                if (contestant == theContestant.Value)
                Console.WriteLine(theContestant.Key + "-" + theContestant.Value);
            }
        }
    }
}
