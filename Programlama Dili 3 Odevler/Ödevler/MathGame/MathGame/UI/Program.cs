using System;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        public static WFMain WFMain = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                WFMain = new WFMain();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
            }
            catch (Exception ex)
            {
                //todo log
                Console.WriteLine(ex.Message);
            }
            Application.Run(WFMain);

        }
    }
}
