using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SweepStakes TestSweepStake = new SweepStakes();
            TestSweepStake.Sweepstakes("NHK");
            Console.ReadLine();
        }
    }
}
