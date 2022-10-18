using System;
using System.Diagnostics;
using OOP3.source.GUI.Forms;

namespace OOP3
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainScreen());
        }
    }
}