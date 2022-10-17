// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
//
using OOP3.source.CLI;
using OOP3.source.Core;
//
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
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}