using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Enum Yapısı";
            Console.WriteLine(Gunler.pazar); // PAZARIN STRİNG OLARAK KARŞILIĞINI YAZDI
            Console.WriteLine((int)Gunler.cumartesi);//cmrtsinin numerik değerine erişim

            int sicaklik = 32;
            if (sicaklik<=(int)HavaDurumu.Normal)
            {
                Console.WriteLine("DIŞARIYA ÇIKMAK İÇİN HAVANIN BİRAZ DAHA ISINMASINI BEKLE...");
            }
            else if (sicaklik>=(int)HavaDurumu.Sicak)
            {
                Console.WriteLine("DIŞARIYA ÇIKMAK İÇİN ÇOK SICAK BİR GÜN...");
            }
            else if (sicaklik >= (int) HavaDurumu.Normal && sicaklik < (int) HavaDurumu.CokSicak)
            {
                Console.WriteLine("HADİ DIŞARIYA ÇIKALIM...");
            }

            Console.ReadKey();

        }
    }

    enum Gunler
    {
        pazartesi=1,
        salı,
        çarşamba,
        periembe,
        cuma=24,
        cumartesi,
        pazar

    }

    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sicak=25,
        CokSicak=30
    }
}
