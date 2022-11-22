using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.source.User
{
    using source.Person;

    public enum AccountType
    {
        ADMINISTRATOR = 0,
        ANONYMOUS = 1,
        REGISTERED = 2
    };

    class User : Person
    {
        private string AccountName;
        private string AccountPassword;
        private AccountType AccountType;
        private Bitmap AvatarImage;

        public User(
            string username,
            string password,
            string name,
            string surname,
            DateOnly birthday
        ) : base(name, surname, birthday)
        {
            AccountName = username;
            AccountPassword = password;
        }

        public User(
            string username,
            string password,
            string avatar,
            string name,
            string surname,
            DateOnly birthday
        ) : base(name, surname, birthday)
        {
            AccountName = username;
            AccountPassword = password;
            AvatarImage = new Bitmap(avatar);
        }

        public override string ToString()
        {
            return Username + " " + Name + " " + Surname + " " + BirthDate;
        }

        public string Username
        {
            get { return AccountName; }
            set { AccountName = value; }
        }
        public string Password
        {
            get { return AccountPassword; }
        }

        public bool ChangePassword(string currentPass, string newPass)
        {
            if (currentPass == AccountPassword)
            {
                AccountPassword = newPass;
                return true;
            }
            return false;
        }

        public AccountType UserAccountType
        {
            get { return AccountType; }
        }
        protected AccountType SetUserAccountType
        {
            set { AccountType = value; }
        }
        public Bitmap Avatar
        {
            get { return AvatarImage; }
            set { AvatarImage = value; }
        }
    }
}
