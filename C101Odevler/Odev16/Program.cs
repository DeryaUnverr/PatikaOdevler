using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev16
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Tarih Formatları
            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(dateTime.ToString("MM/dd/yyyy"));
            //Console.WriteLine(dateTime.ToString("HH:mm"));
            //Console.WriteLine(dateTime.ToString("hh:mm tt"));
            //Console.WriteLine(dateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            //Console.WriteLine(dateTime.ToString("MM/dd/yyyy HH:mm:ss")); 
            #endregion
            #region DayOfWeek
            //DateTime dt = new DateTime(2020, 11, 14);
            //Console.WriteLine("Haftanın günü {0:d} is {1}.", dt, dt.DayOfWeek); 
            #endregion
            #region DayOfYear
            //DateTime dateTime = DateTime.Now;
            //string dayOfYear = dateTime.DayOfYear.ToString();

            //Console.WriteLine("Güncel tarih: " + dateTime.ToString());
            //Console.WriteLine("Yılın günü : " + dayOfYear); 
            #endregion
            #region Subtract
            //DateTime startTime = DateTime.Now;
            //DateTime endTime = DateTime.Now.AddSeconds(135);
            //TimeSpan span = endTime.Subtract(startTime);

            //Console.WriteLine("seconds: " + span.Seconds);
            //Console.WriteLine("minutes: " + span.Minutes);
            //Console.WriteLine("hours: " + span.Hours);
            //Console.WriteLine("days: " + span.Days); 
            #endregion

            Console.WriteLine("Tarih ve saati:" + DateTime.Now);        //Şimdiki tarih ve saati veriyor
            Console.WriteLine("Sadece Tarih:" + DateTime.Now.Date);   //şimdiki tarihi veriyor
            Console.WriteLine("Gün:" + DateTime.Now.Day);    //Gün
            Console.WriteLine("Ay:" + DateTime.Now.Month);  //Ay
            Console.WriteLine("Yıl:" + DateTime.Now.Year);   //Yıl
            Console.WriteLine("Saat" + DateTime.Now.Hour);   //Saat
            Console.WriteLine("Dakika" + DateTime.Now.Minute); //Dakika
            Console.WriteLine("Saniye" + DateTime.Now.Second); //Saniye

            Console.WriteLine("Haftanın hangi günü:" + DateTime.Now.DayOfWeek);
            Console.WriteLine("Yılın hangi günü:" + DateTime.Now.DayOfYear);

            Console.WriteLine("Yılın hangi günü:" + DateTime.Now.ToLongDateString());
            Console.WriteLine("Yılın hangi günü:" + DateTime.Now.ToShortDateString());
            Console.WriteLine("Yılın hangi günü:" + DateTime.Now.ToLongTimeString());
            Console.WriteLine("Yılın hangi günü:" + DateTime.Now.ToShortTimeString());
            //zaman  Ekleme bölümü
            Console.WriteLine(DateTime.Now.AddDays(3));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(3));
            Console.WriteLine(DateTime.Now.AddYears(3));
            Console.WriteLine(DateTime.Now.AddMonths(3));
            Console.WriteLine(DateTime.Now.AddMilliseconds(3));
            //Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));//16
            Console.WriteLine(DateTime.Now.ToString("ddd"));//Car
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Carsamba
            Console.WriteLine(DateTime.Now.ToString("MM"));//16
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Car
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//Carsamba
            Console.WriteLine(DateTime.Now.ToString("yy"));//Car
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//Carsamba

            //Math Kütüphanesi
            Console.WriteLine("//Math Kütüphanesi//");
            Console.WriteLine(Math.Abs(-25));
            Console.WriteLine(Math.Sin(-25));
            Console.WriteLine(Math.Cos(-25));
            Console.WriteLine(Math.Tan(-25));

            Console.WriteLine(Math.Ceiling(22.3));//23
            Console.WriteLine(Math.Round(22.3));//22
            Console.WriteLine(Math.Round(22.7));//23
            Console.WriteLine(Math.Floor(22.7));//22

            Console.WriteLine(Math.Max(2, 6));
            Console.WriteLine(Math.Min(2, 6));

            Console.WriteLine(Math.Pow(2, 6));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Log(9));
            Console.WriteLine(Math.Exp(3));
            Console.WriteLine(Math.Log10(10));
        }
    }
}
