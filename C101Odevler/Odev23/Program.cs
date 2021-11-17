using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Stratic Sınıf ve Uyeler";
            Console.WriteLine($"çalışan sayısı :{Calisan.CalisanSayisi} ");
            Calisan calisan = new Calisan("Ayse","Yılmaz","IK");
            Console.WriteLine($"çalışan sayısı :{Calisan.CalisanSayisi} ");
            Console.WriteLine("-------------------");
            Console.WriteLine(Islem.Topla(100, 200));
            Console.WriteLine(Islem.Cikar(200, 50));
            
            Console.ReadKey();

        }
    }

    class Calisan
    {
        private static int calisanSayisi;
        private string Isim;
        private string Soyİsim;
        private string Departman;

        static  Calisan()
        {
            calisanSayisi = 0;
        }
        public Calisan(string isim, string soyIsim, string departman)
        {
            this.Isim = isim;
            this.Soyİsim = soyIsim;
            this.Departman = departman;
            calisanSayisi++;
        }

        public static int CalisanSayisi
        {
            get => calisanSayisi;
           
        }
    }

    static class Islem
    {
        public static int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
