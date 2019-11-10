using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject37
{
    class Program
    {
        static void Main(string[] args)
        {
            int paraUstu, banknot10, banknot5, banknot2, kalan = 0;

            //1.Adım: Fiyat bilgisinin istenmesi.
            Console.WriteLine("Aldığınız ürünün/ürünlerin toplam fiyatını giriniz: ");
            int fiyat = Convert.ToInt32(Console.ReadLine());

            //2.Adım: Ödeme için hangi yöntem kullanılacağının bilgisinin istenmesi, nakitse giriş yapılacak
            //para miktarının sorulması.
            string odemeYontemi = null;

            Console.WriteLine("Şu anda sadece nakit ödemeler için hizmet verebiliyoruz. Nakit ödeme yapacaksanız devam edin, " +
                "işlemi iptal etmek için \"Q\"ya basın.");
            odemeYontemi = Console.ReadLine().ToUpper();

            if (odemeYontemi == "Q")
            {
                return;
            }
            Console.WriteLine("Ödeme yapacağınız miktarı giriniz: ");
            int paraGirisi = Convert.ToInt32(Console.ReadLine());

            if (paraGirisi < fiyat)
            {
                Console.WriteLine("Girdiğiniz miktar yetersiz.");
            }
            //3. Adım: Para üstü hesabının yapılması.
            paraUstu = paraGirisi - fiyat;
            Console.WriteLine("Para üstü = " + paraUstu);
            //4. Adım: Para üstünün modu alınır.
            if (paraUstu % 10 == 0)
            {
                banknot10 = paraUstu / 10;
                Console.WriteLine("Para üstü " + banknot10 + " tane 10'luk banknot ile verilmiştir.");
            }
            else if (paraUstu % 10 != 0)
            {
                banknot10 = paraUstu / 10;
                kalan = paraUstu % 10;
                if (kalan % 5 == 0)
                {
                    banknot5 = kalan / 5;

                    Console.WriteLine("Para üstü " + banknot10 + " 10'luk banknot, " + banknot5 + " tane 5'lik banknot ile verilmiştir.");
                }
                else if (kalan % 5 != 0)
                {
                    if (kalan % 2 == 0)
                    {
                        banknot2 = kalan / 2;
                        Console.WriteLine("Para üstü " + banknot10 + " 10'luk banknot, " + banknot2 + " tane 2'lik banknot ile verilmiştir.");
                    }
                    else
                    {
                        banknot5 = kalan / 5;
                        kalan = paraUstu % 5;
                        banknot2 = kalan / 2;
                        Console.WriteLine("Para üstü " + banknot10 + " 10'luk banknot, " + banknot5 + " tane 5'lik " + banknot2 +
                            " tane 2'lik banknot ile verilmiştir.");
                        Console.WriteLine();
                        if (kalan % 2 == 1)
                        {
                            Console.WriteLine("Şu anda 1'lik banknotumuz bulunmadığından, 1 liranızı veremiyoruz. " +
                                "48 saat içerisinde fişinizle kasaya giderek alabilir ya da sokak hayvanlarına bağış yapabilirsiniz" +
                                ".");
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
