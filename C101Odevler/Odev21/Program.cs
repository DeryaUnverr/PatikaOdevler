using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev21
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Title = "Sınıf tanımlama - Erişim Bildirgeçleri";
            Calisan calisan1 = new Calisan("Ali","Sonda",12345,"Muhasebe");
            //calisan1.Name = "Derya";
            //calisan1.SurName = "Ünver";
            //calisan1.Department = "IT";
            //calisan1.Number = 12345;
           
            Calisan calisan3=new Calisan("Yıldız","Demir");
            calisan3.CalisanBilgileri();
            Console.WriteLine("-----------------------------");
            calisan1.CalisanBilgileri();
            Console.WriteLine("-----------------------------");
            Calisan calisan2 = new Calisan();
            calisan2.Name = "Deniz";
            calisan2.SurName = "Yıldız";
            calisan2.Department = "IK";
            calisan2.Number = 67890;
            calisan2.CalisanBilgileri();

            Console.ReadKey();

        }
    }

    class Calisan
    {
        public Calisan()
        {
            
        }
        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Name = ad;
            this.SurName = soyad;
            this.Number = no;
            this.Department = departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Name = ad;
            this.SurName = soyad;
       
        }
        public string Name;
        public string SurName;
        public string Department;
        public int Number;

        public void CalisanBilgileri()
        {
            Console.WriteLine($"Çalışan Adı: {Name}");
            Console.WriteLine($"Çalışan SoyadAdı: {SurName}");
            Console.WriteLine($"Çalışan Department: {Department}");
            Console.WriteLine($"Çalışan Numarası: {Number}");
        }
    }
}
