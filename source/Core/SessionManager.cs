using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.source.Core
{
    using OOP3.source.Log;
    using OOP3.source.Person;
    using OOP3.source.User;
    class SessionManager
    {
        private static SessionManager instance = null;
        private static readonly object padlock = new object();
        public List<Form> openForms = new List<Form>();
        public List<User> users = new List<User>();
        public User currentUser = null;
        private int UserId = -1;

        private SessionManager()
        {
            users.Add(new User("test", "test", "Testname", "Testsurname", new DateOnly(2000, 03, 23)));
            users.Add(new User("admin", "admin", AccountType.ADMINISTRATOR, "admin", "admin", new DateOnly(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day)));
            users.Add(new User());

            Log.INFO("{0}", users[0].Age);
        }

        public bool Login(string name, string pass)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if(name == users[i].Username && pass == users[i].Password && users[i].Type != AccountType.ANONYMOUS)
                {
                    currentUser = users[i];
                    UserId = i;
                    return true;
                }
            }
            // if(name != user.Username)
            // {
            //     Log.ERROR($"Username is incorrect!");
            //     return false;
            // }
            // if(pass != user.Password)
            // {
            //     Log.ERROR($"Password is incorrect!");
            //     return false;
            // }
            return false;
        }

        public void Logout()
        {
            currentUser = null;
            UserId = -1;
        }

        public bool isInstance()
        {
            if (instance == null) return false;
            return true;
        }

        
        public static SessionManager Instance
        {
            get
            {
                lock(padlock)
                {
                    if(instance == null)
                    {
                        instance = new SessionManager();
                    }
                    return instance;
                }
            }
        }

    }
}
