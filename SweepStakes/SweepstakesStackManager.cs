using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<SweepStakes> SweepStack = new Stack<SweepStakes>();
        public void InsertSweepstakes(SweepStakes sweepstakes)
        {
            SweepStack.Push(sweepstakes);
        }

        public void GetSweepstakes()
        {

        }
    }
}
