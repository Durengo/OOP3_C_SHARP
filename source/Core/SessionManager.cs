using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.source.Core
{
    using OOP4.source.Log;
    using OOP4.source.Person;
    using OOP4.source.User;

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
            users.Add(
                new Registered(
                    "test",
                    "test",
                    "Testname",
                    "Testsurname",
                    new DateOnly(2000, 03, 23)
                )
            );
            users.Add(
                new Administrator(
                    "admin",
                    "admin",
                    "admin",
                    "admin",
                    new DateOnly(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day)
                )
            );

            Log.INFO("{0}", users[0].Age);
        }

        public bool Login(string name, string pass)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (
                    name == users[i].Username
                    && pass == users[i].Password
                    && users[i].UserAccountType != AccountType.ANONYMOUS
                )
                {
                    currentUser = users[i];
                    UserId = i;
                    return true;
                }
            }
            return false;
        }
        public bool CreateUser(
            string username,
            string password,
            string imagePath,
            string name,
            string surname,
            DateOnly birthday
        )
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Username == username)
                {
                    return false;
                }
            }
            if(imagePath == "")
            {
            SessionManager.Instance.users.Add(
                new Registered(username, password, name, surname, birthday)
            );
            }
            else{
            SessionManager.Instance.users.Add(
                new Registered(username, password, imagePath, name, surname, birthday)
            );
            }
            return true;
        }

        public void Logout()
        {
            currentUser = null;
            UserId = -1;
        }

        public bool isInstance()
        {
            if (instance == null)
                return false;
            return true;
        }

        public static SessionManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SessionManager();
                    }
                    return instance;
                }
            }
        }
    }
}
