using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject12
{
    class Program
    {
        static void Main(string[] args)
        {
            int gun = (int)DateTime.Now.DayOfWeek;
            while (true)
            {
                Console.WriteLine("1- 7 arasında bir gün değeri girin: ");
                gun = Convert.ToInt32(Console.ReadLine());
                if (gun >= 1 && gun <= 7)
                {
                    switch (gun)
                    {
                        case 1:
                            Console.WriteLine("Pazartesi");
                            break;
                        case 2:
                            Console.WriteLine("Salı");
                            break;
                        case 3:
                            Console.WriteLine("Çarşamba");
                            break;
                        case 4:
                            Console.WriteLine("Perşembe");
                            break;
                        case 5:
                            Console.WriteLine("Cuma");
                            break;
                        case 6:
                            Console.WriteLine("Cumartesi");
                            break;
                        case 7:
                            Console.WriteLine("Pazar");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Düzgün gir!");
                }
                    Console.ReadLine();
            }
        }
    }
}