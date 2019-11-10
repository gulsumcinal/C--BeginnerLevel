using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject04
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 350;
            Console.Write("INT gösteriliyor:");
            Console.WriteLine(sayi);
            Console.WriteLine("");

            //Bir alt satırdaki conversion explicit bir conversion'dır.
            //Fakat uygun değildir.
            //Çünkü, büyük veri tipi, daha küçük bir veri tipine
            //dönüştürülmek istenmiştir. Bu durum veri kaybına yol açacağı için hata vermiştir.
            //Ama bilinçli bir çevirim söz konusu ise,
            //bu durum explicit conversion ile çözülebilir.
            //byte sayiByte = (byte)sayi;
            byte sayiByte = (byte)sayi;
            Console.Write("INT to BYTE gösteriliyor:");
            Console.WriteLine(sayiByte);
            Console.WriteLine("");

            long sayiLong = (long)sayi;
            Console.Write("INT to LONG gösteriliyor:");
            Console.WriteLine(sayiLong);
            Console.WriteLine("");

            double x = 1234.7;
            int a1;
            int a2;
            //cast double to int
            a1 = (int)x; //truncate double
            a2 = Convert.ToInt32(x);

            Console.Write("DOUBLE to INT gösteriliyor:");
            Console.WriteLine(a1);
            Console.WriteLine("");

            Console.Write("DOUBLE to INT Conversion gösteriliyor:");
            Console.WriteLine(a2);

            Console.ReadLine();
        }
    }
}
