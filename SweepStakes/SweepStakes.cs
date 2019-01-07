using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class SweepStakes
    {
        public int MaxNumber = 3;
        public List<Contestant> ContestantList = new List<Contestant>();
        public void Sweepstakes(string name)
        {
            Console.WriteLine("Welcome to the "+name+" sweepstakes!");
            for (int i = 0; i < MaxNumber; i++)
            {
                Contestant newContestant = new Contestant();

                Console.WriteLine("Contestant #"+(i+1)+", Please enter your name and email address.");
                RegisterContestant(newContestant);
                ContestantList.Add(newContestant);
            }
            Console.WriteLine(PickWinner()+ " is the winner!"); 
        }
        public void RegisterContestant(Contestant contestant)
        {
            Console.Clear();
            contestant.FirstName = UserInterface.GetFirstName();
            UserInterface.NewLine();
            contestant.LastName = UserInterface.GetLastName();
            UserInterface.NewLine();
            contestant.EmailAddress = UserInterface.GetEmail();
            UserInterface.NewLine();
            contestant.RegistrationNum = UserInterface.GetRegisterNum();
            UserInterface.NewLine();
            Console.WriteLine("Press enter so that the next contestant may enter.");
            Console.ReadLine();
        }
        public string PickWinner()
        {
            Random r = new Random();
            int WinningNumber = r.Next(1, MaxNumber + 1);
            foreach (Contestant contestant in ContestantList)
            {
                if (WinningNumber == contestant.RegistrationNum)
                {
                    return contestant.FirstName;
                }
                else
                {
                    continue;
                }
            }
            return null;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant name: "+contestant.FirstName+" "+contestant.LastName);
            Console.WriteLine("Contestant Email: "+contestant.EmailAddress);
            Console.WriteLine("Contestant #: "+contestant.RegistrationNum);
        }

    }
}
