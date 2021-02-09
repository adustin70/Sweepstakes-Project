using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepStakes
{
    class SweepstakeStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack;

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack = new Stack<Sweepstakes>();
            stack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop();
        }
    }
}
