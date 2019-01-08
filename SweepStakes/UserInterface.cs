using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public static class UserInterface 
    {
        static int regNum = 0;
        public static string GetFirstName()
        {
            Console.WriteLine("What is your first name?");
            return Console.ReadLine();
        }

        public static string GetLastName()
        {
            Console.WriteLine("What is your last name?");
            return Console.ReadLine();
        }

        public static string GetEmail()
        {
            Console.WriteLine("What is your email address?");
            return Console.ReadLine();
        }

        public static int GetRegisterNum()
        {
            regNum += 1;
            Console.WriteLine("Your registered number is: "+regNum);
            return regNum;
        }

        public static void ReduceRegisterNum()
        {
            regNum -= 1;
        }

        public static void ClearRegisterNum()
        {
            regNum = 0;
        }

        public static void NewLine()
        {
            Console.WriteLine("");
        }

        public static string DecideManager()
        {
            bool validation = false;
            while (!validation)
            {
                Console.WriteLine("Would you like to stack your Sweepstakes or queue them? Type s/q.");
                string choice = Console.ReadLine();
                if (choice == "s" || choice == "q")
                {
                    validation = true;
                    return choice;
                }
                else
                {
                    Console.WriteLine("Please try again.");
                    validation = false;
                }
            }
            return null;
        }

        public static int ManageNumContest(string name)
        {
            bool validation = false;
            while (!validation)
            {
                Console.WriteLine("How many contestants should there be for sweepstake '"+name+"'? Type a positive integer between 2 and 20.");
                string choice = Console.ReadLine();
                int intchoice;

                if (int.TryParse(choice, out intchoice))
                {
                    if (intchoice >= 2 && intchoice <= 20)
                    {
                        validation = true;
                        return intchoice;
                    }
                }
                else
                {
                    validation = false;
                }
                Console.WriteLine("Please try again.");
            }
            return 2;
        }
    }
}
