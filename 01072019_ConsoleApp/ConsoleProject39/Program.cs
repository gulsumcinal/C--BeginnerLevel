using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleProject39
{
    class Program
    {
        /*
         Kullan?c?n?n girdi?i (123(456)789) format?ndaki say?n?n iç k?sm?ndaki parantezden ba?layarak, parantezin içindek say? ters çevrilecek ve parantez slinecek.
         Bu i?lem Tüm parantezler bitene kadar devam edecek.
        */
        static void Main(string[] args)
        {
            //int sayac = 0;
            //int i = 0;
            //Console.WriteLine("Lütfen veri giriniz. Örn: (123(456)789)...");
            //string girilen = Console.ReadLine();

            //foreach (var gir in girilen)
            //{
            //    sayac++;
            //}
            //string[] deneme = new string[sayac];
            //foreach (var gir in girilen)
            //{
            //    deneme[i] = Convert.ToString(gir);
            //    i++;
            //}
            //do
            //{
            //    int sayac2 = 0;
            //    int parantezTakip = 0;
            //    int parantezTakip1 = 0;
            //    try
            //    {
            //        foreach (var gir in deneme)
            //        {
            //            if (gir == ("("))
            //            {
            //                parantezTakip = sayac2;
            //            }
            //            else if (gir == (")"))
            //            {

            //                parantezTakip1 = sayac2;
            //                break;
            //            }
            //            sayac2++;
            //        }
            //        deneme[parantezTakip] = null;
            //        deneme[parantezTakip1] = null;
            //        Array.Reverse(deneme, parantezTakip, (parantezTakip1 - parantezTakip));
            //        foreach (var item in deneme)
            //        {
            //            Console.Write(item);
            //        }
            //        Console.ReadLine();
            //    }
            //    catch
            //    {
            //        Console.Write("Lütfen geçerli bir deðer giriniz.");
            //        continue;
            //    }

            //}
            //while (true);

            string arama;
            string girdi;
            Console.WriteLine("Lütfen veri giriniz. Örn: (123(456)789)...");
            girdi = Console.ReadLine();

            while (girdi.Contains("(") || girdi.Contains(")"))
            {
                int index1 = girdi.IndexOf(')');
                arama = girdi.Substring(0, index1);
                int index2 = arama.LastIndexOf('(');
                girdi = ReversePart(girdi, index1, index2);

                girdi = girdi.Remove(index1, 1);
                girdi = girdi.Remove(index2, 1);

                Console.WriteLine("O zaman dans : " + girdi);
                Console.ReadLine();
            }
        }
        static string ReversePart(string text, int index1, int index2)
        {
            char[] chars = text.ToCharArray();

            for (int a = index2, b = index1; a < b; ++a, --b)
            {
                char temp = chars[a];
                chars[a] = chars[b];
                chars[b] = temp;
            }
            return new string(chars);
        }
    }
}

