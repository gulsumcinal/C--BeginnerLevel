using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir alt satırdaki a değişkeni tanımlanırsa 
            //Birinci ve ikinci scope da ki a değişkenleri yeniden tanımlanamaz.
            //Ancak kullanılabilir. Yani Main bloğunda tanımlanan a değişkeninin
            //faaliyet alanı açılan diğer bloklarda devam etmektedir.
            //Üst seviyede açılan bloklar alt seviyedeki açılan blokları kapsar.
            //int a = 65;
            {
                //Birinci scope
                int a = 19;
                Console.WriteLine("a nın değeri = " + a);
                Console.ReadLine();
            }

            //Aşağıdaki kod compile hatası verir.
            //Çünkü a değişkeni bu scope da tanımlı değil.
            //Console.WriteLine(a);

            {
                //İkinci scope
                int a = 22;
                Console.WriteLine("a nın değeri = " + a);
                Console.ReadLine();
            }

        }
    }
}
