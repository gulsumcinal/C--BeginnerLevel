using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject35
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# sınavı için örnek

            Ogrenci ogr = new Ogrenci();
            ogr.Yas = 20;
            Metot2(ogr);
            Console.WriteLine("Öğrenci yaş değeri: " + ogr.Yas);
            Console.ReadLine();
        }
        private static void Metot2(Ogrenci o)
        {
            o.Yas = 30;
        }
    }
}
