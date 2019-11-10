using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girdiği satır ve sütun sayısı kadar 
            //yıldız koyan program

            int satir, sutun;
            Console.Write("Satır sayısı giriniz: ");
            satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sütun sayısı giriniz: ");
            sutun = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < satir; i++)
            {

                for(int j = 0; j < sutun; j++)
                {
                    Console.Write("*    ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
