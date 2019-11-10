using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjects38
{
    class Program
    {
        //Kullanıcı alacağı para üstünü girsin
        //Para üstü veren makinede sadece 2, 5 ve 10'luk banknotlar bulunmaktadır
        //Kullanıcıya en az adet banknot ile para üstü veren uygulamayı yazınız.
        //Eğer kullanıcı para üstü olarak 1 ve 3 rakamlarını yazarsa sistem uyarı mesajı versin
        static void Main(string[] args)
        {
            int onlukAdedi, beslikAdedi, ikilikAdedi, kalan, paraUstu;

            Console.WriteLine("Lütfen para üstü giriniz.");
            paraUstu = Convert.ToInt32(Console.ReadLine());

            onlukAdedi = paraUstu / 10;
            paraUstu = paraUstu % 10;
            beslikAdedi = paraUstu / 5;
            paraUstu = paraUstu % 5;
            ikilikAdedi = paraUstu / 2;
            paraUstu = paraUstu % 2;

            kalan = paraUstu;

            if(kalan > 0)
            {
                if(beslikAdedi > 0)
                {
                    int ekIkilikAdedi;
                    beslikAdedi--;
                    ekIkilikAdedi = (5 + kalan) / 2;
                    ikilikAdedi = ikilikAdedi + ekIkilikAdedi;
                    kalan = 0;
                }
                else
                {
                    if(onlukAdedi>0)
                    {
                        int ekIkilikAdedi;
                        onlukAdedi--;
                        beslikAdedi++;
                        ekIkilikAdedi = (5 + kalan) / 2;
                        ikilikAdedi = ikilikAdedi + ekIkilikAdedi;
                        kalan = 0;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen 1 ve 3 dışında bir para üstü giriniz.");
                    }
                    Console.WriteLine("Onluk sayısı = " + onlukAdedi);
                    Console.WriteLine("Beslik sayısı = " + beslikAdedi);
                    Console.WriteLine("İkilik sayısı = " + ikilikAdedi);
                    Console.WriteLine("Kalan = " + kalan);
                    Console.ReadLine();
                }
            }
        }
    }
}
