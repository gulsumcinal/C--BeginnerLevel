using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject31
{
    class Program
    {
        static void Main(string[] args)
        {
            //++'nın yerinin sonuca etkisi
            int sayi1 = 4;
            int sayi2 = 6;
            while (true)
            {
                //int snc1 = sayi1++ + sayi2;
                //Console.WriteLine("sayi1 = " + sayi1);
                //Console.WriteLine("sayi2 = " + sayi2);
                //Console.WriteLine("snc1 = " + snc1);
                //Console.ReadLine();

                //int snc2 = ++sayi1 + sayi2;
                //Console.WriteLine("sayi1 = " + sayi1);
                //Console.WriteLine("sayi2 = " + sayi2);
                //Console.WriteLine("snc2 = " + snc2);
                //Console.ReadLine();

                //int snc3 = ++sayi1 + sayi2++;
                //Console.WriteLine("sayi1 = " + sayi1);
                //Console.WriteLine("sayi2 = " + sayi2);
                //Console.WriteLine("snc3 = " + snc3);
                //Console.ReadLine();

                //int snc4 = ++sayi1 + sayi2++ + sayi1;
                //Console.WriteLine("sayi1 = " + sayi1);
                //Console.WriteLine("sayi2 = " + sayi2);
                //Console.WriteLine("snc4 = " + snc4);
                //Console.ReadLine();

                int snc5 = ++sayi1 + sayi2++ + ++sayi1 + ++sayi1 + ++sayi2;
                Console.WriteLine("sayi1 = " + sayi1);
                Console.WriteLine("sayi2 = " + sayi2);
                Console.WriteLine("snc5 = " + snc5);
                Console.ReadLine();
            }
        }
    }
}
