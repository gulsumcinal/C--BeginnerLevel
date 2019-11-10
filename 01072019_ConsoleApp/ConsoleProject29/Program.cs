using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectt27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girdiği sayının faktöriyeli.
            int faktoriyel = 1;
            string faktoriyelSonucu = " ";
            int kacaKadar;

            Console.WriteLine("Hangi sayının faktöriyelini hesaplamak istiyorsun?");
            kacaKadar = int.Parse(Console.ReadLine());

            for (
                int i = 1; i <= kacaKadar; i++)
            {
                if (i < kacaKadar)
                {
                    faktoriyel = faktoriyel * i;
                    faktoriyelSonucu = faktoriyelSonucu + i;
                    Console.Write(faktoriyelSonucu + "*" + i + "=" + faktoriyel);
                }
                else if (i == kacaKadar)
                {
                    faktoriyel = faktoriyel * i;
                    faktoriyelSonucu = faktoriyel + i + "=";
                }
                
                Console.ReadLine();
            }
        }
    }
}
