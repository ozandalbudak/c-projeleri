using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sezar_şifreleme
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i, uzunluk,j;
            string alfabe = "abcçdefgğhıijklmnoöprsştuüvyz";
            int oteleme = 3;
            string metin="ahmet";
            char[] dizi = metin.ToCharArray();
            string sifreli_metin = null;
            uzunluk = metin.Length;
              for (i=0;i<uzunluk;i++)
              { 
                 for(j=0;j<29;j++)
                  {
                      if(dizi[i]==alfabe[j])
                      {
                          sifreli_metin += alfabe[(j + oteleme) % 29];
                      }
                  }
              }
            /*
            for (i = 0; i < uzunluk; i++)
            {
                for (j = 0; j < 29; j++)
                {
                    if (metin[i] == alfabe[j])
                    {
                        if ((j - oteleme) < 0)
                        {
                            sifreli_metin +=alfabe[(j - oteleme + 29)];
                        }
                        else {
                            sifreli_metin += alfabe[(j - oteleme)];
                        }
                    }
                }
            }*/
            Console.WriteLine(sifreli_metin);
            

            Console.ReadLine();
        }
    }
}
