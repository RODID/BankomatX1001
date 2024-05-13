using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Bankomat
{
    internal class AtmManager
    {
        public List<User> ListOfUsers = new List<User>();
        public AtmManager() 
        {
            ListOfUsers.Add(new User(001,"Kalle", 3345, "1001777", "Visa", 10));
            ListOfUsers.Add(new User(002, "Ahmed", 1312, "1001888", "Swedbank", 40));
            ListOfUsers.Add(new User(003, "Savo", 1531, "1001999", "Länsförsäkringarna", 150));
            ListOfUsers.Add(new User(004, "Hamorsh", 1337, "1001111", "SEB", 100));


        }

        public void Run()
        {
            PrintOptions();
        }

        public void PrintOptions()
        {
            try
            {
                Console.WriteLine("Thank You For Choosing EvilBank!");
                Console.WriteLine("Please enter your user ID:");
                int userIdInput = int.Parse(Console.ReadLine());

                User user = ListOfUsers.FirstOrDefault(u => u.UserId == userIdInput);

                if (user == null)
                {
                    Console.WriteLine("User not found.");
                    return;
                }

                Console.WriteLine("Insert PIN:");
                int pinInput = int.Parse(Console.ReadLine());

                if (pinInput != user.GetPin())
                {
                    Console.WriteLine("Invalid PIN.");
                    return ;
                }
                Console.WriteLine("Please choose from one of the following options...");
                Console.WriteLine("1. Deposit.");
                Console.WriteLine("2. Withdraw.");
                Console.WriteLine("3. Show Balance.");
                Console.WriteLine("4. Exit.");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Deposit(user);
                        break;

                    case "2":
                        Withdraw(user);
                        break;

                    case "3":
                        ShowBalance(user);
                        break;

                    case "4":
                        Exit(user); 
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
           
        }

        private void Exit(User user)
        {
            PrintOptions();
        }

        public void Deposit(User user)
        {
            Console.WriteLine("How much would you like to deposit");

            double deposit = double.Parse(Console.ReadLine());
            user.SetBalance(deposit + user.GetBalance());

            Console.WriteLine("Thank you for trusting EvilBank your $$, Your new balance is: " + user.GetBalance() + "$.");

        }

        private void Withdraw(User user)
        {
            Console.WriteLine("How much $$ would you like to withdraw: ");

            double withdraw = double.Parse(Console.ReadLine());
            user.SetBalance(withdraw - user.GetBalance());

            Console.WriteLine("You Withdrawed " + withdraw + "$, Your new blanace is: " + user.GetBalance() + "$.");
        }

        private void ShowBalance(User user)
        {
            Console.WriteLine("Hello, " + user.GetName());
            Console.WriteLine("Evil Card: " + user.GetCardType());
            Console.WriteLine("Evil Number: " + user.GetCardNumber());
            Console.WriteLine("Evil balance: " + user.GetBalance() + "$.");

        }
        

    }
}
