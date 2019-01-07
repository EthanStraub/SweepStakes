using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<SweepStakes> SweepQueue = new Queue<SweepStakes>();
        public void InsertSweepstakes(SweepStakes sweepstakes)
        {
            SweepQueue.Enqueue(sweepstakes);
        }

        public void GetSweepstakes()
        {
            
        }
    }
}
