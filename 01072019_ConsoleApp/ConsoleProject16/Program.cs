using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject16
{
    class Program
    {
        static void Main(string[] args)
        {
            int sinav1, sinav2, ortalama;
            try
            {
                for(int i = 0; i< 2; i++)
                {
                    Console.Write("Lütfen 1. sınav notunu giriniz: ");
                    sinav1 = Convert.ToInt32(Console.ReadLine());
                    if(sinav1 > 100 || sinav1 < 0)
                    {
                        Console.WriteLine("Lütfen uygun değer giriniz.");
                    }
                    Console.Write("Lütfen 2. sınav notunu giriniz: ");
                    sinav2 = Convert.ToInt32(Console.ReadLine());
                    if (sinav1 > 100 || sinav1 < 0)
                    {
                        Console.WriteLine("Lütfen uygun değer giriniz.");
                    }
                    ortalama = (sinav1 + sinav2) / 2;
                    if (ortalama < 50)
                    {
                        Console.WriteLine("Sınıfta kaldınız.");
                        Console.WriteLine("ortalamanız: " + ortalama);
                        Console.WriteLine("");
                    }
                    else if(ortalama <= 100)
                    {
                        Console.WriteLine("ortalamanız: " + ortalama);
                        Console.WriteLine("Sınıfı geçtiniz.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("100'den küçük değer giriniz.");
                        Console.WriteLine("");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Lütfen uygun değer giriniz.");
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
