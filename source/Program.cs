using System;
using System.Diagnostics;
using OOP4.source.GUI.Forms;

namespace OOP4
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
