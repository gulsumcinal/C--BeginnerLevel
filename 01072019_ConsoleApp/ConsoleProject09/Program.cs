using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject09
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1;
            int sayi2;
            int fark = 0;

            Console.WriteLine("1. sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            if(sayi1 > sayi2)
            {
                Console.Write("fark = ");
                fark = ((sayi1 * 2) - sayi2);
                Console.WriteLine(fark);
            }
            
            else
            {
                Console.Write("fark = ");
                fark = ((sayi2 * 2) - sayi1);
                Console.WriteLine(fark);
            }

            Console.ReadLine();
        }
    }
}
