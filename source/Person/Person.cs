using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP3.source.Person
{
    public class Person
    {
        private string FirstName;
        private string LastName;
        private DateOnly DateOfBirth;
        private int CurrentAge = 0;

        public Person(string name, string surname, DateOnly dateOfBirth)
        {
            FirstName = name;
            LastName = surname;
            DateOfBirth = dateOfBirth;
            CalculateAge();
        }

        private void CalculateAge()
        {
            CurrentAge = DateTime.Today.Year - DateOfBirth.Year;
        }

        public string Info()
        {
            return FirstName + "; " + LastName + "; " + DateOfBirth + "; " + CurrentAge + ";";
        }

        // Getters & Setters
        public string Name
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public string Surname
        {
            get { return LastName; }
            set { LastName = value; }
        }

        public DateOnly BirthDate
        {
            get { return DateOfBirth; }
            set { DateOfBirth = value; }
        }
        public int Age
        {
            get { CalculateAge(); return CurrentAge; }
            private set { CurrentAge = value; CalculateAge(); }
        }

    }
}