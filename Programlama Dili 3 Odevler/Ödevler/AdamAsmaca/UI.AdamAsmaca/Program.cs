using MODEL.AdamAsmaca;
using System;
using System.Windows.Forms;

namespace UI.AdamAsmaca
{
    static class Program
    {
        public static int WORDLENGHT = 0;
        public static Keyword KEYWORD=null;
        public static Score SCORE = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            KEYWORD = new Keyword("DB.txt");
            SCORE = new Score("Score.txt");
            try
            {
             
                string lenght = Microsoft.VisualBasic.Interaction.InputBox("Oyuna başlamadan önce kaç harflik bir kelime istediğini bize söylemelisin. Rassal bir değer istiyorsan boş bırak.", "Bilgi Girişi", "Örn: 3");
                WORDLENGHT = int.Parse(lenght);
             
            }
            catch 
            {
                Random randomLenght = new Random();
                WORDLENGHT = randomLenght.Next(1, 5);
                MessageBox.Show(String.Format("Senin için rassal değer ürettim. Buda {0}, bilgine arz ederim.", WORDLENGHT));
            }

            Application.Run(new WFMain());
        }
    }
}
