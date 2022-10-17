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
        private SessionManager() {}
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

        bool Login(User user, string name, string pass)
        {
            if(name != user.Username)
            {
                Log.ERROR($"Username is incorrect!");
                return false;
            }
            if(pass != user.Password)
            {
                Log.ERROR($"Password is incorrect!");
                return false;
            }
            return true;
        }

    }
}
