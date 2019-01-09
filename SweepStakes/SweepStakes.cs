using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace SweepstakesProject
{
    class Sweepstakes
    {
        public string name;
        public int maxNumber;
        public int winningNumber;
        public IDictionary<int, string> contestNameDict = new Dictionary<int, string>();
        public IDictionary<int, string> contestEmailDict = new Dictionary<int, string>();

        public Sweepstakes(string name)
        {
            this.name = name;
            maxNumber = UserInterface.ManageNumContest(name);
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.FirstName = UserInterface.GetFirstName();
            UserInterface.NewLine();
            contestant.LastName = UserInterface.GetLastName();
            UserInterface.NewLine();
            contestant.EmailAddress = UserInterface.GetEmail();
            UserInterface.NewLine();
            contestant.RegistrationNum = UserInterface.GetRegisterNum();
            UserInterface.NewLine();

            Console.WriteLine("Is all of the following information valid? y/n.");
            PrintContestantInfo(contestant);

            if (ValidateInfo())
            {
                Console.WriteLine("Great! Press enter so that the next contestant may enter.");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                UserInterface.ReduceRegisterNum();
                RegisterContestant(contestant);
            }
        }
        public string PickWinner()
        {
            Random r = new Random();
            winningNumber = r.Next(1, maxNumber + 1);
            foreach (KeyValuePair<int, string> contestant in contestNameDict)
            {
                if (contestant.Key == winningNumber)
                {
                    return contestant.Value;
                }
            }
            return null;
        }

        public string GetWinnerAddress()
        {
            foreach (KeyValuePair<int, string> contestant in contestEmailDict)
            {
                if (contestant.Key == winningNumber)
                {
                    return contestant.Value;
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

        public bool ValidateInfo()
        {
            bool validation = false;
            while (!validation)
            {
                string choice = Console.ReadLine();
                if (choice == "y")
                {
                    validation = true;
                }
                else if (choice == "n")
                {
                    validation = false;
                    Console.WriteLine("I see. Please retype your information then.");
                    break;
                }
                else
                {
                    Console.WriteLine("Please type in 'y' for Yes, and 'n' for No.");
                }
            }
            return validation;
        }

        public void SendMail(string address, string name)
        {
            // Command line argument must the the SMTP host.
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("biblebot99@gmail.com", "Carbuncle#9");

            MailMessage mm = new MailMessage(address, address, "Congratulations, "+name+"!", "You've won the sweepstake!");
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
        }
    }
}
