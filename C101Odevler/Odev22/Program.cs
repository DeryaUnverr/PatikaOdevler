using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kapsulleme (Encapsulation) -> Koruma";
            Ogrenci ogrenci= new Ogrenci();
            ogrenci.Isim = "Derya";
            ogrenci.SoyIsim = "Ünver";
            ogrenci.OgrenciNo = 123;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.SınıfAtlat();
            Console.WriteLine("--------------------------");
            ogrenci.OgrenciBilgileriniGetir();
            Ogrenci ogrenci2= new Ogrenci("Deniz","Baykuş",456,1);
            ogrenci2.OgrenciBilgileriniGetir();
            ogrenci2.SınıfDusur();
            ogrenci2.OgrenciBilgileriniGetir();
            Console.ReadKey();

        }
    }

    class Ogrenci
    {
        public Ogrenci()
        {
            
        }
        public Ogrenci(string isim, string soyIsim, int ogrenciNo, int sinif)
        {
            this.isim = isim;
            this.soyIsim = soyIsim;
            this.ogrenciNo = ogrenciNo;
            this.sinif = sinif;
        }
        private string isim;
        private string soyIsim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get => isim; //isimi RETURN ETTİ
            set => isim = value; //isime VALUE ATADI
        }

        public string SoyIsim
        {
            get => soyIsim;
            set => soyIsim = value;
        }

        public int OgrenciNo
        {
            get => ogrenciNo;
            set => ogrenciNo = value;
        }

        public int Sinif
        {
            get => sinif;
            set
            {
                if (value<1)
                {
                    Console.WriteLine("Sınıf En az 1 olabilir");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
            
            }
           
        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("------------- Öğrenci Bilgileri ----------");
            Console.WriteLine($"Ogrenci Adı : {this.Isim}");
            Console.WriteLine($"Ogrenci SoyIsim : {this.SoyIsim}");
            Console.WriteLine($"Ogrenci OgrenciNo : {this.OgrenciNo}");
            Console.WriteLine($"Ogrenci Sinif : {this.Sinif}");
        }

        public void SınıfAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SınıfDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
