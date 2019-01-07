using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
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
            Console.WriteLine("Your registered number is "+regNum);
            return regNum;
        }

        public static void NewLine()
        {
            Console.WriteLine("");
        }
    }
}
