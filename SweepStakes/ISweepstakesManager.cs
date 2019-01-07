using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    interface ISweepstakesManager
    {
        void InsertSweepstakes(SweepStakes sweepstakes);
        void GetSweepstakes();
    }
}
