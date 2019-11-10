using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject25
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet, sayi = 0, toplam = 0;
            string sayilar = " ";
            Console.WriteLine("Kaç adet sayı toplayacaksınız: ");
            adet = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= adet; i++)
            {
                try
                {
                    Console.WriteLine(i + ". sayıyı giriniz: ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    toplam = toplam + sayi;
                    if(i < adet)
                    {
                        sayilar = sayilar + sayi + "+";
                    }
                    else if(i == adet)
                    {
                        sayilar = sayilar + sayi;
                    }
                }
                catch(FormatException nesne)
                {
                    Console.WriteLine("Hatalı giriş!" + nesne.Message);
                    i--;
                }
            }
            Console.WriteLine("Toplam: " + sayilar + "=" + toplam);
            Console.ReadLine();
        }
    }
}
