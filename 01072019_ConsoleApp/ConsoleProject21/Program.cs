using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject21
{
    class Program
    {
        static void Main(string[] args)
        {
            //1- Sayma işleminin 1'den başlayarak 100'e kadar birer birer
            //devam ettirilmesi, 5 ve 5 in katlarına gelindiğinde ekrana sayı yeribe BOM yazdırılması

            //EKrana yazılan her sayıyı bir süre bekletmek için
            //Thread.Sleep(500) kullanabilirsiniz

            //2- Kendisine ve katlarına gelindiğinde BOM denilecek olan sayının
            //Console ekranından kullanıcı tarafından girilmesinin istenmesi, oyundaki
            //sayma işleminin bu girilen sayıya göre doğru şekilde ekrana yazdırılması

            //3- BOM denilecek sayının aynı şekilde kullanıcı tarafından girilmesinin
            //ardından oyunun bilgisayar tarafından başlatılması, sırayla kullanıcı ve
            //bilgisayar arasında devam ettirilmesi

            //NOT: Aşama 3'de BOM srası kullanıcıya geldiğinde ekrandan
            //BOM yeribe sayı girilirse kullanıcı oyunu kaybeder.
            //Bilgisayar oyunu karar yapılarına dayalı olarak oynayacağından
            //kaybetmesi durumu göz önüne alınmayacaktır. Oyun 100'e kadar devam ettirilecek olup 
            //kullanıcının kaybetmiş olması durumunda beraberlik durumu geçerli olacaktır ve
            //ekrana "OYUN BERABERE" yazdırılmalıdır.

            //Birinci oyun
            //for (int i = 0; i < 100; i++)
            //{
            //    System.Threading.Thread.Sleep(500);
            //    Console.WriteLine(i);
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine("BOM");
            //        continue;
            //    }
            //}
            //Console.ReadLine();

            //Console.WriteLine("Hangi sayı katlarında BOM yazılmasını istersin?");
            //int BOMKatsayisi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < 100; i++)
            //{
            //    System.Threading.Thread.Sleep(500);
            //    if (i % BOMKatsayisi == 0)
            //    {
            //        Console.WriteLine("BOM");
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            int pcSayi = 1;
            int kullaniciSayi;
            Console.Write("BOM sayısını giriniz: ");
            int bom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Oyun başlıyor....");
            Console.WriteLine("");
            while (pcSayi < 101)
            {
                System.Threading.Thread.Sleep(500);
                if (pcSayi % bom != 0)
                {
                    Console.WriteLine(pcSayi);
                }
                else
                {
                    Console.WriteLine("BOM");
                }
                if ((pcSayi + 1) % bom == 0)
                {
                    string text = Console.ReadLine().ToUpper();
                    if (text != "BOM")
                    {
                        Console.WriteLine("PATLADINIZ!!");
                        return;
                    }
                    else
                    {
                        pcSayi += 2;
                    }
                }
                else
                {
                    kullaniciSayi = Convert.ToInt32(Console.ReadLine());
                    if (kullaniciSayi != (pcSayi + 1))
                    {
                        Console.WriteLine("PATLADINIZ!!");
                        return;
                    }
                    else
                    {
                        pcSayi += 2;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
