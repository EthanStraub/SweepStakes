using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class MarketingFirm
    {
        int testNum = 0;

        public ISweepstakesManager manager;
        public void MakeManager()
        {
            string managerType = UserInterface.DecideManager();

            if (managerType == "s")
            {
                manager = new SweepstakesStackManager();
            }
            else if(managerType == "q")
            {
                manager = new SweepstakesQueueManager();
            }
            else
            {
                return;
            }
        }

        public void MakeSweepstake()
        {
            testNum += 1;

            Sweepstakes newSweepstake = new Sweepstakes("TEST#"+testNum);
            manager.InsertSweepstakes(newSweepstake);
        }

        public void RunSweepstake(Sweepstakes newSweepstake)
        {
            SetupSweepstake(newSweepstake);

            Console.WriteLine(newSweepstake.PickWinner() + " is the winner!");
            Console.WriteLine("An email will be sent to their inbox at ("+newSweepstake.GetWinnerAddress()+"), notifying them of their success in the sweepstake.");
            newSweepstake.SendMail(newSweepstake.GetWinnerAddress(), newSweepstake.PickWinner());
            Console.WriteLine("Thank you for participating! Press ENTER to exit the program, or to start the next sweepstake.");
            Console.ReadLine();
            Console.Clear();
        }

        public void SetupSweepstake(Sweepstakes sweepstake)
        {
            for (int i = 0; i < sweepstake.maxNumber; i++)
            {
                Contestant newContestant = new Contestant();

                UserInterface.NewLine();
                Console.WriteLine("Welcome to the " + sweepstake.name + " Sweepstakes!");
                UserInterface.NewLine();

                Console.WriteLine("Contestant #" + (i + 1) + ", Please enter your name and email address.");
                sweepstake.RegisterContestant(newContestant);
                sweepstake.contestNameDict.Add(newContestant.RegistrationNum, (newContestant.FirstName+" "+newContestant.LastName));
                sweepstake.contestEmailDict.Add(newContestant.RegistrationNum, newContestant.EmailAddress);
            }
        }
    }
}
