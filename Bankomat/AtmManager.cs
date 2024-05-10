using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    internal class AtmManager
    {
        public List<User> ListOfUsers = new List<User>();
        public AtmManager() 
        {
            ListOfUsers.Add(new User(001,"Kalle", 3345, 1001777, "Visa", 20000));
            ListOfUsers.Add(new User(002, "Ahmed", 1312, 1001888, "Swedbank", 4890));
            ListOfUsers.Add(new User(003, "Savo", 1531, 1001999, "Länsförsäkringarna", 150000));
            ListOfUsers.Add(new User(004, "Hamorsh", 1337, 1001111, "SEB", 350000));


        }

        public void Run()
        {
            PrintOptions();
        }

        public void PrintOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit.");
            Console.WriteLine("2. Withdraw.");
            Console.WriteLine("3. Show Balance.");
            Console.WriteLine("4. Exit.");
            
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Deposit();
                    break;

                case "2":
                    Withdraw();
                    break;

                case "3":
                    ShowBalance();
                    break;

                default:
                    Console.WriteLine("Try again something went wrong!");
                    break;

            }
        }

        public void Deposit(User users)
        {
            Console.WriteLine("How much would you like to deposit");

            double deposit = double.Parse(Console.ReadLine());
            users.SetBalance(deposit + users.GetBalance());

            Console.WriteLine("Thank you for your $$ Your new balance is: " + deposit + users.GetBalance());
        }

        public void Withdraw(User users)
        {
            Console.WriteLine("How much $$ would you like to withdraw: ");

            double withdraw = double.Parse(Console.ReadLine());
            users.SetBalance(withdraw - users.GetBalance());

            Console.WriteLine("You Withdrawed " + withdraw + ", Your new blanace is: " + users.GetBalance());
        }

        public void ShowBalance(User user)
        {
            Console.WriteLine("Your current balance: " + user.GetBalance() + "$.");

        }

    }
}
