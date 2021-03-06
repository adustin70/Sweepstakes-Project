﻿using System;
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
            Name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            if (contestants.Count == 0)
            {
                key++;
                contestants.Add(key, contestant);
                contestant.ContestantRegistrationNumber = key;
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
                Console.WriteLine(contestant.ContestantLastName + "," + contestant.ContestantFirstName + ": " + contestant.ContestantEmail);
        }
    }
}
