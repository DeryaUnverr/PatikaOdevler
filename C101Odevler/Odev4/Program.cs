using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Convert Sınıfı
            //string sayi = "245";
            //int carpim = sayi * 3;
            //int sayi2 = sayi;

            //int sayi2 = 240;
            //byte sayi3 = sayi2;

            // implicit type casting / bilinçsiz tür dönüşümü
            // implicit conversation
            // implicit convert
            //byte sayi4 = 125;
            //int sayi5 = sayi4;

            //string sayiInt = "255";
            //byte sayiByte = Convert.ToByte(sayiInt);
            //double sayiDouble = Convert.ToDouble(sayiInt);
            //long sayiLong = Convert.ToInt64(sayiInt);
            //string sayiString = Convert.ToString(sayiInt);
            //short sayiShort = Convert.ToInt16(sayiInt);

            //Console.Write("Ad: ");
            //string ad = Console.ReadLine();
            //Console.Write("Soyad: ");
            //string soyad = Console.ReadLine();
            //Console.Write("Yaş: ");
            //byte yas = Convert.ToByte(Console.ReadLine());

            //Console.Write("Birinci sayı: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci sayı: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = sayi1 + sayi2;
            //Console.WriteLine("Girmiş olduğunuz sayıların toplamı : "+toplam);
            //bool durum = Convert.ToBoolean(2); 
            #endregion

            #region Parse Methodu
            // Parse methodu stringleri başka tiplere çevirmek için kullanılır.
            // Convert sınıfı içerisindeki metodlar tüm tipleri başka tiplere çevirir.
            //string sayi = "25";
            //byte sayiByte = byte.Parse(sayi);
            //int sayiInt = int.Parse(sayi);
            //double sayiDouble = double.Parse(sayi); 
            #endregion

            #region ToString Methodu
            // ToString Methodu her şeyi stringe çevirir
            //int sayi = 2534;
            //bool durum = true;
            //string sayiString = sayi.ToString();
            //string durumString = durum.ToString(); 
            #endregion

            Console.ReadKey();
        }
    }
}
