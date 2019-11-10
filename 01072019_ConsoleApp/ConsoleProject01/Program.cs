using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Birinci scope(blok)
            //int a = 20;
            //Console.WriteLine(a);
            //Console.ReadLine();
            //Console.ReadKey();
            //Console.Read();

            string isim;
            string soyIsim;

            Console.WriteLine("Lutfen isminizi giriniz.");
            isim = Console.ReadLine();

            Console.WriteLine("Lütfen soyisminizi giriniz.");
            soyIsim = Console.ReadLine();

            string adSoyad;
            adSoyad = isim + " " + soyIsim;
            Console.WriteLine(adSoyad);
            Console.WriteLine(isim + "--" + soyIsim);

            string yas;
            Console.WriteLine("Lütfen yaşınızı giriniz.");
            yas = Console.ReadLine();

            Console.WriteLine("Merhaba" + " " + isim + " " + soyIsim + " " + "(" + yas + ")");
            Console.WriteLine(isim + " " + soyIsim + " " + " \"Merhaba\" " + " " + yas);
            
            adSoyad = isim + " \"Merhaba\" " + soyIsim;
            Console.WriteLine(adSoyad);

            adSoyad = isim + " " + "\\Merhaba\\" + " " + soyIsim;
            Console.WriteLine(adSoyad);

            adSoyad = isim + " " + "\\" + "Merhaba" + "\\" + " " + soyIsim;
            Console.WriteLine(adSoyad);

            string TCnumarası;
            Console.WriteLine("Lütfen TC kimlik numaranızı giriniz.");
            TCnumarası = Console.ReadLine();

            adSoyad = "Merhaba" + " " + isim + " " + soyIsim + " " + "(" + yas + ")" + " " + "-" + " " + TCnumarası;
            Console.WriteLine(adSoyad);
            
            Console.ReadLine();
        }
    }
}