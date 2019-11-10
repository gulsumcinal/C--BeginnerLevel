using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject17
{
    class Program
    {
        static void Main(string[] args)
        {
            int vize, final, durum;
            for(int i = 0; i < 2; i++)
            {
                try
                {
                    Console.Write("Vize: ");
                    vize = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Final: ");
                    final = Convert.ToInt32(Console.ReadLine());

                    durum = (vize * 40 / 100) + (final * 60 / 100);

                    if (durum >= 60)
                    {
                        Console.WriteLine("Başarılı!");
                    }
                    else
                    {
                        Console.WriteLine("Başarısız!");
                    }
                }
                catch
                {
                    Console.WriteLine("Lütfen uygun değer giriniz.");
                }
            }
            Console.ReadLine();
        }
    }
}
