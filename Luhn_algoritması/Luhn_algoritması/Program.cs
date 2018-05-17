using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luhn_algoritması
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] kartSayi = new int[16];            
            bool result=false;

            Console.WriteLine("16 Haneli kart numaranızı giriniz");
            string sayi =  Console.ReadLine();
            char[] kartNo = sayi.ToCharArray();
            
            for (int i = 0; i < 16; i++)
            {
                kartSayi[i] = Convert.ToInt32(kartNo[i].ToString());
            }
            Console.WriteLine(luhn(kartSayi,result));   
            Console.ReadLine();

        }
        public static bool luhn(int[] s,bool sonuc)
        {
            int tekTop = 0;
            int ciftTop = 0;
            for (int j = 0; j < 8; j++)
            {
                tekTop += s[2 * j + 1];
                
                if ((s[j * 2] * 2) >= 10)
                {   
                    ciftTop += s[j * 2] * 2 - 9;
                }
                else
                {
                    ciftTop += s[j * 2] * 2;
                }
            }
            int toplam = tekTop + ciftTop;
            sonuc = (toplam % 10).Equals(0);
           return sonuc;
        }
    }
}
