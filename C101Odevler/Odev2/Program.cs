using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sekil = " ---------------------------------";
            string str1 = string.Empty;
            str1 = "Derya Ünver ";
            string ad = "Derya ";
            string soyad = "Ünver";
            string tamIsim = $"{ad} {soyad}";
            Console.WriteLine(tamIsim);

            Console.WriteLine(sekil);

            int sayi1 = 5;
            int sayi2 = 6;
            int islem = sayi2 * sayi1;

            bool kontrol = 10 > 2;
          
            //dönüşüm
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            //dateTime
            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);
            string dateTim2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTim2);
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);


            Console.ReadKey();
        }
    }
}
