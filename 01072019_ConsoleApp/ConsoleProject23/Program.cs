using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject23
{
    class Program
    {
        static void Main(string[] args)
        {
            int baslangic = 0;
            int bitis = 100;
            int orta;
            int tutulan;
            int sayac = 1;
            Random rnd = new Random();
            tutulan = rnd.Next(1, 100);

            while (true)
            {
                orta = (baslangic + bitis) / 2;
                Console.WriteLine(sayac + ". Tahmin: " + orta);
                if (orta < tutulan)
                {
                    sayac++;
                    Console.WriteLine("Tutulan sayi, tahmin sayısından BÜYÜKTÜR");
                    baslangic = orta;
                }
                else if(orta > tutulan)
                {
                    sayac++;
                    Console.WriteLine("Tutulan sayi, tahmin sayısından KÜÇÜKTÜR");
                    bitis = orta;
                }
                else
                {
                    Console.WriteLine("Tutulan sayi {0} ve {1}.denemede BULUNDU", tutulan, sayac);
                    Console.ReadLine();
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}
