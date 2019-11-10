using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject11
{
    class Program
    {
        static void Main(string[] args)
        {
            double yazili1, yazili2, ortalama = 0;
            while(true)
            {
                try
                {
                    Console.Write("1. yazılı notunu giriniz: ");
                    yazili1 = Convert.ToInt32(Console.ReadLine());
                    if (yazili1 > 100)
                    {
                        Console.Write("Hatalı not!");
                    }
                    else
                    {
                        Console.Write("2. yazılı notunu giriniz: ");
                        yazili2 = Convert.ToInt32(Console.ReadLine());
                        if (yazili2 > 100)
                        {
                            Console.Write("Hatalı not!");
                        }
                        else
                        {
                            ortalama = (yazili1 + yazili2) / 2;
                            if (ortalama >= 0 && ortalama <= 24)
                            {
                                Console.Write("5'lik sistemde notunuz: 0");
                                Console.Write("Ortalamanız: " + ortalama);
                            }
                            else if (ortalama >= 25 && ortalama <= 44)
                            {
                                Console.Write("5'lik sistemde notunuz: 1");
                                Console.Write("Ortalamanız: " + ortalama);
                            }
                            else if (ortalama >= 45 && ortalama <= 54)
                            {
                                Console.Write("5'lik sistemde notunuz: 2");

                                Console.Write("Ortalamanız: " + ortalama);
                            }
                            else if (ortalama >= 55 && ortalama <= 69)
                            {
                                Console.Write("5'lik sistemde notunuz: 3");

                                Console.Write("Ortalamanız: " + ortalama);
                            }
                            else if (ortalama >= 70 && ortalama <= 84)
                            {
                                Console.Write("5'lik sistemde notunuz: 4");
                                Console.Write("Ortalamanız: " + ortalama);
                            }
                            else if (ortalama >= 85 && ortalama <= 100)
                            {
                                Console.Write("5'lik sistemde notunuz: 5");
                                Console.Write("Ortalamanız: " + ortalama);
                            }
                        }
                    }
                }
                catch
                {
                    Console.Write("Uygun olmayan değer girildi.");
                }
                Console.ReadLine();
            }
           
        }
    }
}