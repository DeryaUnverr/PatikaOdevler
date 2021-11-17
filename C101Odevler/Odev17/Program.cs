using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Odev17
{
    class Program
    {
        static void Main(string[] args)
        {


            //Diziyi Listeye Çevirme
            string[] dizi = { "A", "B", "C" };
            List<string> diziListesi = new List<string>(dizi);
            foreach (var item in diziListesi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------");
            //Listeyi temizleme 
            diziListesi.Clear();
            //liste içerisinde nesne tutmak
            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            Kullanicilar kullanici = new Kullanicilar();
            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici.Isim = "Derya";
            kullanici.SoyIsim = "Ünver";
            kullanici.Yas = 25;
            yeniListe.Add(kullanici);
            kullanici2.Isim = "Duygu";
            kullanici2.SoyIsim = "Ünver";
            kullanici2.Yas = 18;
            yeniListe.Add(kullanici2);
           
            //Yazım Şekli 1
            //foreach (var item2 in yeniListe)
            //{
            //    Console.WriteLine($"{item2.Isim} {item2.SoyIsim} {item2.Yas}");
            //}

            //Yazım Şekli 2
            yeniListe.ForEach(item=>Console.WriteLine($"{item.Isim} {item.SoyIsim} {item.Yas}"));

            Console.ReadLine();
        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyIsim;
        private int yas;

        public string Isim
        {
            get
            {
                return isim;
            }
            set
            {
                isim = value;
            }
        }

        public string SoyIsim
        {
            get
            {
                return soyIsim;
            }
            set
            {
                soyIsim = value;
            }
        }

        public int Yas
        {
            get
            {
                return yas;
            }
            set
            {
                yas = value;
            }
        }


    }
}
