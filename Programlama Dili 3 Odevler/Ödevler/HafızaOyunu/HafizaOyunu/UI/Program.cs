using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        public static string FIRSTUSERNAME,SECONDUSER;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FIRSTUSERNAME = Microsoft.VisualBasic.Interaction.InputBox("1.Oyuncunun Adı", "Oyuncu Adı", "1.Oyuncu");
            SECONDUSER = Microsoft.VisualBasic.Interaction.InputBox("2.Oyuncunun Adı", "Oyuncu Adı", "2.Oyuncu");
            if (FIRSTUSERNAME=="")
            {
                FIRSTUSERNAME = "1.Oyuncunu";
            }
            if (SECONDUSER=="")
            {
                SECONDUSER = "2.Oyuncunu";
            }
            Application.Run(new WFMain());

        }
    }
}
