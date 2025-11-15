using System;
using System.Windows.Forms;

namespace BOOSEapp
{
    /// <summary>
    /// Entry point of the BOOSE Drawing Application.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
