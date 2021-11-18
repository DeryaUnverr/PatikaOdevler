using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev24
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;
            Console.WriteLine("Dikdortgen alan hesabı {0}",dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgenStruct= new Dikdortgen_Struct(3,4);
            //dikdortgenStruct.KisaKenar = 3;
            //dikdortgenStruct.UzunKenar = 4;
            Console.WriteLine("Dikdortgen struct alan hesabı {0}", dikdortgenStruct.AlanHesapla());

            Dikdortgen_Struct dikdortgenstruct; 
            dikdortgenstruct.KisaKenar = 3;
            dikdortgenstruct.UzunKenar = 4;
            Console.WriteLine("Dikdortgen struct newsiz  alan hesabı {0}", dikdortgenStruct.AlanHesapla());
            Console.ReadLine();
        }
    }
    class Dikdortgen
    {
        public Dikdortgen()
        {
            KisaKenar = 3;
            UzunKenar = 4;
        }
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
             return this.KisaKenar * this.UzunKenar;
        }
    }

    struct  Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen_Struct(int kisaKenar,int uzunKenar)
        {
            KisaKenar = 3;
            UzunKenar = 4;
        }
       

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}
