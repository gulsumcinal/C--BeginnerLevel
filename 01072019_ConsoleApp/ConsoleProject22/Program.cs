using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject22
{
    class Program
    {
        static void Main(string[] args)
        {
            int tahmin = 0, tutulan = 0, sayac = 1;
            Random rnd = new Random();
            tutulan = rnd.Next(1, 100);
            while (tahmin != tutulan)
            {
                try
                {
                    Console.Write(sayac + ". Tahmininiz: ");
                    tahmin = Convert.ToInt32(Console.ReadLine());
                    if (tahmin == tutulan)
                    {
                        Console.WriteLine("Tebrikler sayıyı " + sayac + ". tahmininizde buldunuz");
                    }
                    else if (tahmin > 100 || tahmin < 0)
                    {
                        Console.WriteLine("Tahmin sayısı 1 ile 10 arasında olmalıdır.");
                        sayac--;
                    }
                    else if (tahmin < tutulan)
                    {
                        Console.WriteLine((tutulan + tahmin) / 2 + "'den büyük");
                    }
                    else if (tahmin > tutulan)
                    {
                        Console.WriteLine((tutulan + tahmin) / 2 + "'den küçük");
                    }
                    sayac++;
                }
                catch
                {
                    Console.WriteLine("Lütfen sayı giriniz!");
                }
            }
            Console.ReadLine();
        }
    }
}
