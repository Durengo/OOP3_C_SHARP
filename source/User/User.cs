﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.source.User
{
    using source.Person;
    public enum AccountType {ADMINISTRATOR = 0, ANONYMOUS = 1, REGISTERED = 2};
    
    class User : Person
    {
        private string AccountName;
        private string AccountPassword;
        private AccountType AccountType;

        public User()
        : base("ANONYMOUS", "UNDEFINED", new DateOnly(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day))
        {
            AccountName = "NULL";
            AccountPassword = "NULL";
            AccountType = AccountType.ANONYMOUS;
        }
        public User(string username, string password, string name, string surname, DateOnly birthday)
        : base(name, surname, birthday)
        {
            AccountName = username;
            AccountPassword = password;
            AccountType = AccountType.REGISTERED;
        }
        public User(string username, string password, AccountType type, string name, string surname, DateOnly birthday)
        : base(name, surname, birthday)
        {
            AccountName = username;
            AccountPassword = password;
            AccountType = type;
        }

        public string Username
        {
            get { return AccountName; }
            set { AccountName = value;}
        }
        public string Password
        {
            get { return AccountPassword; }
            set { AccountPassword = value; }
        }
        public AccountType Type
        {
            get { return AccountType; }
            set { Type = value; }
        } 
    }
}
