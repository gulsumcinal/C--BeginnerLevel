using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden iki ürünün fiyatı ayrı ayrı girildiğinde iki ürünün toplam fiyatı
            //200 TL'den fazla ise 2. üründen %25 indirim yaparak 
            //iki ürün için toplam ödenecek tutarı gösteren uygulama
            double urun1 = 0, urun2 = 0, toplam = 0;
            Console.WriteLine("1. ürünün fiyatını girin. ");
            urun1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. ürünün fiyatını girin. ");
            urun2 = Convert.ToInt32(Console.ReadLine());
            toplam = urun1 + urun2;
            if(toplam <= 200)
            {
                toplam = urun1 + urun2;
                Console.WriteLine("Toplam ödenecek tutar: " + toplam);
                Console.WriteLine("Toplam indirim: 0");
            }
            else
            {
                Console.WriteLine("Toplam indirim: " + urun2 * 0.25);
                toplam = urun1 + urun2 * 0.75;
                Console.WriteLine("Toplam ödenecek tutar: " + toplam);
            }
            Console.ReadLine();
        }
    }
}
