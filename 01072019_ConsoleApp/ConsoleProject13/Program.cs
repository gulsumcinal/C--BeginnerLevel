using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject13
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Kaçıncı ayda olduğunuzu girin: ");
                    int ay = Convert.ToInt32(Console.ReadLine());
                    if (ay <= 12 && ay >= 1)
                    {
                        switch (ay)
                        {
                            case 12:
                            case 1:
                            case 2:
                                Console.WriteLine("Kış mevsimi");
                                break;
                            case 3:
                            case 4:
                            case 5:
                                Console.WriteLine("İlkbahar mevsimi");
                                break;
                            case 6:
                            case 7:
                            case 8:
                                Console.WriteLine("Yaz mevsimi");
                                break;
                            case 9:
                            case 10:
                            case 11:
                                Console.WriteLine("Sonbahar mevsimi");
                                break;
                            default:
                                Console.WriteLine("Ay bilgisini yanlış girdiniz.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Düzgün gir!");
                    }

                }
                catch
                {
                    Console.WriteLine("Düzgün gir!");
                }
                Console.ReadLine();
            }
        }
    }
}
