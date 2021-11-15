using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title("İf-Else / Ternary Operatoru");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz\n1.Toplama\n2.Çıkarma\n3.Çarpma\n4.Bölme");
            char secim = Console.ReadKey(true).KeyChar;
            Console.Write("Birinci sayı: ");
            double sayi1 = double.Parse(Console.ReadLine());
            Console.Write("İkinci sayı: ");
            double sayi2 = double.Parse(Console.ReadLine());
            double sonuc = 0;
            string islem = "";
            if (secim == '1')
            {
                islem = "toplama";
                sonuc = sayi1 + sayi2;
            }
            else if (secim == '2')
            {
                islem = "çıkarma";
                sonuc = sayi1 - sayi2;
            }
            else if (secim == '3')
            {
                islem = "çarpma";
                sonuc = sayi1 * sayi2;
            }
            else if (secim == '4')
            {
                islem = "bölme";
                sonuc = sayi1 / sayi2;
            }
            Console.WriteLine($"Yapmış olduğunuz {islem} işleminin sonucu : {sonuc}");

            //Ternary Operatoru
            string sonuc1 = "";
            int sayi = 5;

            sonuc1 = sayi % 2 == 0 ? "Bu bir çift sayı" : "Bu bir tek sayı";

            string aralik = sayi < 5 ? "Sayı 5'ten küçüktür" : (sayi == 5 ? "Sayı 5'e eşittir" : "Sayı 5'ten büyüktür");

            string sayiKac = sayi == 2 ? "Sayı 2" : (sayi == 3 ? "Sayı 3" : (sayi == 4 ? "Sayı 4" : "Sayı 5"));

            Console.ReadKey();

            // Code snippet
            // 2 kez taba basıp tamamlamaya yarar
        }
    }
}
