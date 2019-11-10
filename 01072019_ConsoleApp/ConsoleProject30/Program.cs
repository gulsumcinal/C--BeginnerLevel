using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10] { 1, 2, 3, 4, 0, 0, 0, 0, 0, 0 };

            Console.WriteLine("Sayılar array büyüklüğü = " + sayilar.Length);
            Console.ReadLine();


            string[] mevsimler = { "ilbahar", "yaz", "sonbahar", "kış" };

            Console.WriteLine("Mevsimler array büyüklüğü = " + mevsimler.Length);
            Console.ReadLine();

            sayilar[4] = 4;
            sayilar[5] = 5;
            sayilar[6] = 6;
            sayilar[7] = 7;
            sayilar[8] = 8;
            sayilar[9] = 9;

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(i + ". eleman ------ " + sayilar[i]);
                Console.ReadLine();
            }
        }
    }
}
