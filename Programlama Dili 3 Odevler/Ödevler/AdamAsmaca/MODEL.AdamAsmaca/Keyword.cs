using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace MODEL.AdamAsmaca
{
    public class Keyword
    {
        private string filePath;
        private string[] keywords;
        /// <summary>
        /// Veri setini okur
        /// </summary>
        /// <param name="filePath">Dosya adresi</param>
        public Keyword(string filePath)
        {
            this.filePath = filePath;
            if ((keywords = ReadTextFile(filePath)) == null)
            {
                throw new Exception("Veritabanı okunamadı veya kelime listesi boş geldi.");
            }

        }
        /// <summary>
        /// Veri setinden kelime getirir
        /// </summary>
        /// <param name="lenght">Kelime uzunluğu</param>
        /// <returns></returns>
        public string GetKeyword(int lenght)
        {
            string[] selectedWords = new string[keywords.Length];
            int i = 0;
            foreach (string item in this.keywords)
            {
                if (item.Length == lenght)
                {
                    selectedWords[i] = item;
                    i++;
                }
            }
            Random randomNumber = new Random();
            return selectedWords[randomNumber.Next(0, i)];
        }
        /// <summary>
        /// Dosya sisteminden text dosyasını okur ve veri setini doldurur.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Tüm kelimeleri getirir
        /// </summary>
        /// <returns></returns>
        public string[] GetAllWord()
        {

            return keywords;
        }
        /// <summary>
        /// Yeni kelime ekler
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool AddWord(string word)
        {
            try
            {
                File.AppendAllText(filePath, string.Format("{0}{1}", word, Environment.NewLine));
                return true;
            }
            catch
            {

                return false;
            }

        }
        /// <summary>
        /// Kelime bul ve sil
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool RemoveWord(int Line)
        {
            try
            {


                StringBuilder sb = new StringBuilder();
                using (StreamReader sr = new StreamReader(filePath))
                {
                    int Countup = 0;
                    while (!sr.EndOfStream)
                    {
                        Countup++;
                        if (Countup != Line)
                        {
                            using (StringWriter sw = new StringWriter(sb))
                            {
                                sw.WriteLine(sr.ReadLine());
                            }
                        }
                        else
                        {
                            sr.ReadLine();
                        }
                    }
                }
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.Write(sb.ToString());
                }

                return true;
            }
            catch
            {

                return false;
            }

        }

    }


}
