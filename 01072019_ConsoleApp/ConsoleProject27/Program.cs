using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girdiği sayının faktöriyeli. Faktöriyel hesaplanırken "*" işareti kullanılarak işlem gösterilecek.
            int sayi = 0;
            int sonuc = 1;
            Console.WriteLine("Faktoriyeli hesaplanacak sayıyı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (sayi == 0)
                {
                    Console.WriteLine("0! = 1");
                }
                for (int i = 1; i <= sayi; i++)
                {

                    sonuc = sonuc * i;
                    if (i < sayi)
                    {
                        Console.Write(i + "*");
                    }
                    else
                    {
                        Console.Write(i + "=" + sonuc);
                    }
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
