using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Homework
{
    static class Program
    {
       
        [STAThread]  /// The main entry point for the application.
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
