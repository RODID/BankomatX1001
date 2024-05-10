using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    internal class AtmManager
    {
        public List<Users> ListOfUsers = new List<Users>();
        public AtmManager() 
        {
            ListOfUsers.Add(new Users(001,"Kalle", 3345, "Visa", 20000));
            ListOfUsers.Add(new Users(002, "Ahmed", 1312, "Swedbank", 4890));
            ListOfUsers.Add(new Users(003, "Savo", 1531, "Länsförsäkringarna", 150000));
            ListOfUsers.Add(new Users(004, "Hamorsh", 1337, "SEB", 350000));


        }

        public void Run()
        {
            MainMenu();
        }

        private void MainMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Quick Balance");
            Console.WriteLine("3. Withdraw Money");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter your password: ");
                    break;

                case "2":
                    Console.WriteLine("Enter your password: ");
                    break;

                case "3":
                    Console.WriteLine("Enter your password: ");
                    break;

                default:
                    Console.WriteLine("Something went wrong try again: ");
                    break;
            }
        }
    }
}
