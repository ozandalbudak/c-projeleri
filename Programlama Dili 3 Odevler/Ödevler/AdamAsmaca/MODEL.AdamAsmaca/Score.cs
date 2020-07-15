using System;
using System.IO;
using System.Text;


namespace MODEL.AdamAsmaca
{
   public class Score
    {
        private string filePath;
        private string[] keywords;
        public Score(string filePath)
        {
            this.filePath = filePath;
            if ((keywords = ReadTextFile(filePath)) == null)
            {
               
            }

        }
        private string[] ReadTextFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath, Encoding.Default);
                if (lines != null && lines.Length > 0)
                {
                    return lines;
                }
                return null;
            }
            catch
            {

                return null;
            }

        }
        public string[] GetScore()
        {

            return keywords;
        }
        public bool AddScore(string score)
        {
            try
            {
                File.AppendAllText(filePath, string.Format("{0}{1}", score+" Tarih:"+System.DateTime.Now, Environment.NewLine));
                return true;
            }
            catch
            {

                return false;
            }

        }
    }
}
