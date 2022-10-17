// See https://aka.ms/new-console-template for more information
using System;

// using OOP3.source.Person;
// using OOP3.source.Log;
// using OOP3.source.Input;
using OOP3.source.GUI.Forms;

namespace OOP3
{
    // class Program
    // {
    //     static void Main()
    //     {
    //         //CLI.CoreTest();
    //         CLI.Test();
    //     }
    // }
    class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}