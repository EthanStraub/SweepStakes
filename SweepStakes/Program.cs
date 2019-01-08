using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Program
    {
        static void Main(string[] args)
        {      
            MarketingFirm firm = new MarketingFirm();
            firm.MakeManager();

            firm.MakeSweepstake();
            firm.MakeSweepstake();
            firm.MakeSweepstake();

            firm.RunSweepstake(firm.manager.GetSweepstakes());
            firm.RunSweepstake(firm.manager.GetSweepstakes());
            firm.RunSweepstake(firm.manager.GetSweepstakes());

            Console.ReadLine();
        }
    }
}
