using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class User
    {
        
        public User()
        {

        }

        public User(int userId, string username, int password, int cardNumber, string cardType, double money)
        {
            UserId = userId;
            Username = username;
            Password = password;
            CardNumber = cardNumber;
            CardType = cardType;
            Money = money;
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }
        public int CardNumber { get; set; }
        public string CardType { get; set; }
        public double Money { get; set; }

        public int GetPin()
        {
            return Password;
        }

        public string GetName()
        {
            return Username;
        }

        public string GetCardType()
        {
            return CardType;
        }

        public double GetBalance()
        {
            return Money;
        } 

        public void SetCardNum(int newCardNum)
        {
            CardNumber = newCardNum;
        }

        public void SetPin(int newPin)
        {
            Password = newPin;
        }

        public void SetName(string newName)
        {
            Username = newName;
        }

        public void SetBalance(double newBalance)
        {
            Money = newBalance;
        }

        


    }
}
