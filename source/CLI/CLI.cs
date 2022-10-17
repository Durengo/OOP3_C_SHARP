using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP3.source.CLI
{
    using OOP3.source.Person;
    using OOP3.source.Log;
    using OOP3.source.Input;
    public class CLI
    {
        public static void CoreTest()
        {
            Console.WriteLine("Hello, World!");
            Log.TRACE("TRACE");
            Log.INFO("INFO");
            Log.WARN("WARN");
            Log.ERROR("ERROR");
            Log.FATAL(true, "FATAL");

            Person p1 = new Person("Namus", "Surnamus", new DateOnly(2000, 3, 23));

            Log.INFO(p1.Info());
            Log.TRACE("TESTING INPUT FOR INT");
            Input.GIBI(5, 6);
            Log.TRACE(Input.GIBS_NW());
            Log.TRACE("ENTER STRING:");
            string input = Input.GIBS();
            Log.INFO(InputValidation.IsWhiteSpace(input));
            Log.INFO(InputValidation.FoundWhiteSpace(input));
            Log.INFO(InputValidation.IsLetters(input));
            Log.INFO(InputValidation.CapitalLetterCount(input));
            Input.GetYesOrNo();
            Log.INFO(InputValidation.NameValidation(input));

            Console.ReadKey();
        }
        public static void Test()
        {
            string name = "";
            string surname = "";
            int year = 0, month = 0, day = 0;
            int CurrentYear = DateTime.Today.Year;

            Log.TRACE("ENTER NAME:");
            name = Input.ValidateName();
            Log.TRACE("ENTER SURNAME:");
            surname = Input.ValidateName();
            Log.TRACE("ENTER DATE OF BIRTH");
            Log.TRACE("ENTER BIRTH YEAR:");
            year = Input.GIBI(CurrentYear - 110, CurrentYear);
        }
    }
}