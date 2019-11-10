using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject03
{
    class Program
    {
        static void Main(string[] args)
        {

            //int sayi1;
            //int sayi2;

            //Console.WriteLine("Lütfen birinci sayiyi giriniz.");
            //sayi1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen ikinci sayiyi giriniz.");
            //sayi2 = int.Parse(Console.ReadLine());

            //string bolme;
            //bolme = int.Parse(Console.ReadLine(sayi1/sayi2));

            //Console.WriteLine("Bolum =" bolme);

            //Console.ReadLine();

            Console.WriteLine("Lütfen birinci sayıyı giriniz.(Bölünen)");
            string sayi1 = Console.ReadLine();
            int sayiBolunen;
            try
            {
                sayiBolunen = Convert.ToInt32(sayi1);
                //int sayiBolunen = Convert.ToInt32(Console.ReadLine);
            }
            catch
            {
                Console.WriteLine("Girmiş olduğunuz ilk değer düzgün değil");
                Console.ReadLine();
                return;
            }
            finally
            {
                Console.WriteLine("Sizi tekrar aramızda görmek isteriz Ali Saraç");
                Console.ReadLine();
            }
            
            Console.WriteLine("Lütfen ikinci sayıyı giriniz.(bölen)");
            string sayi2 = Console.ReadLine();
            int sayiBolen;
            try
            {
                sayiBolen = Convert.ToInt32(sayi2);
                // int sayiBolen = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Girmiş olduğunuz ikinci değer düzgün değil");
                Console.ReadLine();
                return;
            }
            finally
            {
                Console.WriteLine("Sizi tekrar aramızda görmek isteriz Yeşim Uğurlu");
                Console.ReadLine();
            }
            //int sayiBolen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İki sayının birbirine bölümünün sonucu");
            //int / int sonucu fractional part'ı attığı için,
            //yani küsuratı kestiği için, sonuç int olarak hesaplanıyor.
            //Eğer sonucun küsuratlı kısmı varsa ve biz bunu görmek istiyorsak
            //Aşağıdaki satırda olduğu gibi explicit conversion yapılabilir
            //Yani sayılardan birini açık çeklde double'a cast ettik.

            double sonuc;
            try
            {
                sonuc = (double)sayiBolunen / sayiBolen;
                //decimal sonuc = Decimal.Divide(sayiBolunen, sayiBolen);
            }
            catch
            {
                Console.WriteLine("bölme işlemi sırasında hata oluştu");
                Console.ReadLine();
                return;
            }
            finally
            {
                Console.WriteLine("Sizi tekrar aramızda görmek isteriz Gülsüm Çinal");
                Console.ReadLine();
            }

            Console.WriteLine(sonuc);

            Console.ReadLine();
        }
    }
}
