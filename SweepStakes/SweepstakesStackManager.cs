using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepstakeStack = new Stack<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakeStack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            Console.Clear();
            UserInterface.ClearRegisterNum();
            Console.WriteLine("//SWEEPSTAKE REMOVED FROM STACK//");
            return sweepstakeStack.Pop();
        }
    }
}
