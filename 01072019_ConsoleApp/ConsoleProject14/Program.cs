using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject14
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int i = 100; i > 0; i--)
            {
                toplam = toplam + i;
            }
            Console.WriteLine("Sayıların toplamı: " + toplam);
            Console.ReadKey();
        }
    }
}
