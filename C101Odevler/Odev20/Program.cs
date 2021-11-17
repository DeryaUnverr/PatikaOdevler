using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sınıf tanımlama - Erişim Bildirgeçleri";
            Calisan calisan1= new Calisan();
            calisan1.Name = "Derya";
            calisan1.SurName = "Ünver";
            calisan1.Department = "IT";
            calisan1.Number = 12345;
            calisan1.CalisanBilgileri();
            Console.WriteLine("-----------------------------");
            Calisan calisan2= new Calisan();
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
