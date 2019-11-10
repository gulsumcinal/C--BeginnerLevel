using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girdiği sayıya kadar olan değerlerin faktöriyeli
            decimal sayi = 0;
            decimal sonuc = 1;
            Console.WriteLine("Kaç sayının Faktoriyelini hesaplamak istersiniz?");
            sayi = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("0 sayısının faktöriyeli: 1");
                for (decimal i = 1; i <= sayi; i++)
                {
                    sonuc = i * sonuc;
                    Console.Write(i + " sayısının faktöriyeli: " + sonuc);
                    Console.WriteLine("");
                }
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Lütfen uygun değer giriniz.");
            }
            Console.ReadLine();
        }
    }
}
