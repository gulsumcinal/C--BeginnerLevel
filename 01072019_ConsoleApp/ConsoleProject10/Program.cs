using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject10
{
    class Program
    {
        static void Main(string[] args)
        {
            //while(true)
            //    try
            //    {
            //        Console.WriteLine(" ");
            //        Console.WriteLine("Bir sayı giriniz. Programdan çıkmak için \"q\" yada \"Q\" giriniz.");
            //        string girilenDeger = Console.ReadLine();
            //        if (girilenDeger == "Q" || girilenDeger == "q")
            //        {
            //            return;
            //        }
            //        int a = Int32.Parse(girilenDeger);
            //        Console.Write("3000 / " + a + "=");
            //        Console.WriteLine(3000 / a);
            //        Console.WriteLine("İşlem başarılı şekilde sonuçladın.");
            //    }
            //    catch (DivideByZeroException nesne)
            //    {
            //        Console.WriteLine("Sayı sıfıra bölünmez ! " + nesne.Message);
            //    }
            //    catch (Exception nesne) //bu blok sonda olmalı
            //    {
            //        Console.WriteLine("Hata var!" + nesne.Message);
            //    }
            //    //finally
            //    //{
            //    //    Console.WriteLine("Q harfine basarsanız programdan çıkarsınız.");
            //    //}
            string girilenDeger =" ";
            do
            {
                try
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Bir sayı giriniz. Programdan çıkmak için \"q\" yada \"Q\" giriniz.");
                    girilenDeger = Console.ReadLine();
                    
                    int a = Int32.Parse(girilenDeger);
                    Console.Write("3000 / " + a + "=");
                    Console.WriteLine(3000 / a);
                    Console.WriteLine("İşlem başarılı şekilde sonuçladın.");
                }
                catch (DivideByZeroException nesne)
                {
                    Console.WriteLine("Sayı sıfıra bölünmez ! " + nesne.Message);
                }
                catch (Exception nesne) //bu blok sonda olmalı
                {
                    if(girilenDeger != "Q" && girilenDeger != "q")
                    Console.WriteLine("Hata var!" + nesne.Message);
                }
            }
            while (girilenDeger != "Q" && girilenDeger != "q");
            {
                Console.WriteLine("Tekrar bekleriz...");
                Console.ReadLine();
            }

        }
    }
}
