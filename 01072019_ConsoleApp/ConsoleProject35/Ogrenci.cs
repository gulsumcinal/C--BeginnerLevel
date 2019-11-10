using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject35
{
    class Ogrenci
    {
        public int Yas { get; set; }

        public int Isim { get; set; }

        public int Soyisim { get; set; }
        public int Yaslandir(int eskiYas)
        {
            //int yeniYas = eskiYas + 1;
            //Yas = yeniYas;
            //return yeniYas;

            return Yas = eskiYas + 1;
        }
    }
}
