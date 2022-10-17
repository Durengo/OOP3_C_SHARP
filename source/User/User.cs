using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.source.User
{
    class User
    {
        private string AccountName;
        private string AccountPassword;

        public User(string username, string password)
        {
            AccountName = username;
            AccountPassword = password;
        }

        public string Username
        {
            get { return Username; }
            set { AccountName = value;}
        }
        public string Password
        {
            get { return AccountPassword; }
            set { AccountPassword = value; }
        }
    }
}
