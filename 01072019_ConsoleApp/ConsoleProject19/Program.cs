using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Belirlenen kullanıcı adı ve şifre doğru girildiğinde giriş başarılı
            //yanlış girildiğinde girdiğiniz kullanıcı adı veya şifre hatalı
            //mesajı veren program
            //string kullaniciAdi = "", sifre = "";
            //try
            //{
            //    Console.WriteLine("Kullanıcı adını giriniz. ");
            //    kullaniciAdi = Console.ReadLine();
            //    Console.WriteLine("Şifrenizi giriniz.");
            //    sifre = Console.ReadLine();
            //    if (kullaniciAdi == "admin" && sifre == "123456")
            //    {
            //        Console.WriteLine("Giriş başarılı.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kullanıcı adı veya şifre hatalı.");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("Hatalı giriş");
            //}
            //Console.ReadLine();

            string kullaniciAdi = "", sifre = "";
            int sayac = 5;
            while (true)
            {

                Console.WriteLine("Kullanıcı adını giriniz. ");
                kullaniciAdi = Console.ReadLine();

                if (kullaniciAdi != "admin")
                {
                    Console.WriteLine("Kullanıcı adı hatalı.");
                    continue;
                }
                while(sayac >0)
                {
                    Console.WriteLine("Şifrenizi giriniz.");
                    sifre = Console.ReadLine();
                    if (sifre != "123456")
                    {
                        Console.WriteLine("Şifre hatalı.");
                        sayac = sayac - 1;
                        Console.WriteLine("Toplam" + sayac + "deneme hakkınız kaldı.");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                if(sayac == 0)
                {
                    Console.WriteLine("Şifre deneme hakkınız bitmiştir.");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("Giriş başarılı");
                Console.ReadLine();
                return;
            }
        }
    }
}
