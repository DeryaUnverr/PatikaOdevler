using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev7
{
    class Program
    {
        enum Sehir
        {
            Adana = 1, Ankara = 6, Istanbul = 34, Izmir = 35, Kocaeli = 41
        }
        enum Gun
        {
            Pazartesi, Sali, Carsamba, Persembe, Cuma, Cumartesi, Pazar
        }
        enum Cinsiyet
        {
            Kadin, Erkek, Diger
        }
        enum Departman
        {
            Muhasebe, IK, IT, Pazarlama, HalklaIliskiler
        }
        static void Main(string[] args)
        {
            #region Enum Örnek
            //string gun = "Pazartesi";
            //string gun1 = "pazartesi";

            //Gun bugun = Gun.Cumartesi;
            //Gun randevuGunu = Gun.Cumartesi;

            //bool durum1 = gun == gun1;
            //bool durum2 = bugun == randevuGunu;

            //Cinsiyet cns = Cinsiyet.Kadin;
            //Departman dp = Departman.IT; 
            #endregion

            Gun bugun = Gun.Cumartesi;
            switch (bugun)
            {
                case Gun.Pazartesi:
                    Console.WriteLine("Bugün tatil değil");
                    break;
                case Gun.Sali:
                    Console.WriteLine("Bugün tatil değil");
                    break;
                case Gun.Carsamba:
                    Console.WriteLine("Bugün tatil değil");
                    break;
                case Gun.Persembe:
                    Console.WriteLine("Bugün tatil değil");
                    break;
                case Gun.Cuma:
                    Console.WriteLine("Bugün tatil değil");
                    break;
                case Gun.Cumartesi:
                    Console.WriteLine("Bugün tatil");
                    break;
                case Gun.Pazar:
                    Console.WriteLine("Bugün tatil");
                    break;
                default:
                    break;
            }

            Sehir sehir = (Sehir)6;
            Console.WriteLine(sehir);

            Console.ReadKey();
        }
    }
}
