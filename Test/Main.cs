using NUnit.Gui;
using System;

namespace __libs
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            NUnit.Gui.AppEntry.Main(new string[] { @"Test.exe", "/run" });
        }
    }
}
