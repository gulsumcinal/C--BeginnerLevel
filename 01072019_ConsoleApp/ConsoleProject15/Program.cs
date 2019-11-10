using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject15
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayiTane = 0, toplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
               
                if(i%5 == 0 && i%7 != 0)
                {
                    Console.WriteLine(i);
                    toplam = toplam + i;
                    sayiTane++;
                }
            }
            Console.WriteLine("5'e tam bölünen ama 7'ye tam bölünmeyen sayıların toplamı: " + toplam);
            Console.WriteLine("Sayı adedi: " + sayiTane);
            Console.ReadLine();
        }
    }
}
