using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakeQueue = new Queue<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakeQueue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            Console.Clear();
            UserInterface.ClearRegisterNum();
            Console.WriteLine("//SWEEPSTAKE REMOVED FROM QUEUE//");
            return sweepstakeQueue.Dequeue();
        }
    }
}
