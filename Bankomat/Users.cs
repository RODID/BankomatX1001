using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Users
    {
        
        public Users()
        {

        }

        public Users(int userId, string username, int password, string cardType, int money)
        {
            UserId = userId;
            Username = username;
            Password = password;
            CardType = cardType;
            Money = money;
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }
        public string CardType { get; set; }
        public int Money { get; set; }


    }
}
