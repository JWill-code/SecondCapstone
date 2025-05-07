using System;
using System.Windows.Forms;

namespace RedoCapstone
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Currently disabled while testing rest of application.
            //XMLDatabase.RunXml();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formTitleScreen());
        }
    }
}
