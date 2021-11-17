using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KoleksiyonSorularıOdev2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)


            //Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

            //Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.


            //Soru1();
            //Soru2();
            //Soru3();
            Console.ReadLine();

        }

        static void Soru1()
        {
            int[] pozitifSayı = new int[20];
            ArrayList asalListe = new ArrayList();
            ArrayList asalOlmayanListe = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                int sayiGir = Convert.ToInt32(Console.ReadLine());
                if (sayiGir < 0 || sayiGir == 0)
                {
                    Console.WriteLine("Lütfen Pozitif sayı giriniz");
                }
                else
                {
                    pozitifSayı[i] = sayiGir;
                }

            }
            //asal kontrolu
            for (int i = 0; i < pozitifSayı.Length; i++)
            {

                if (pozitifSayı[i] % 2 == 0 && pozitifSayı[i] != 2 || pozitifSayı[i] == 1)
                {
                    //arrayList asal Olmayan

                    asalOlmayanListe.Add(pozitifSayı[i]);

                }
                else
                {

                    //arraylist asal
                    asalListe.Add(pozitifSayı[i]);
                }
            }
            //Asal
            double toplamAsal = 0;
            asalListe.Sort();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Sıralı Asal Liste");
            foreach (var asal in asalListe)
            {
                Console.WriteLine(" {0}", asal);
                toplamAsal = toplamAsal + (int)asal;
            }
            Console.WriteLine("asalListe eleman sayısı : {0}", asalListe.Count);
            double ortalama = toplamAsal / (asalListe.Count);
            Console.WriteLine("Ortalama(asal) => {0}", ortalama);


            //Asal Olmayan
            double toplamAsalOlmayan = 0;
            asalOlmayanListe.Sort();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Sıralı Asal Olmayan Liste");
            foreach (var asalOlmayan in asalOlmayanListe)
            {
                Console.WriteLine(" {0}", asalOlmayan);
                toplamAsalOlmayan = toplamAsalOlmayan + (int)asalOlmayan;
            }
            Console.WriteLine("asalOlmayanListe eleman sayısı : {0}", asalOlmayanListe.Count);
            double ortalama2 = toplamAsalOlmayan / (asalOlmayanListe.Count);
            Console.WriteLine("Ortalama(asal olmayan) =>  {0}", ortalama2);




        }

        static void Soru2()
        {
          
            int[] sayilar = new int[20];

            for (int i = 0; i <20; i++)
            {
                Console.WriteLine($"{i+1}. sayiyi Giriniz:");
                int sayiGir = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = sayiGir;
            }
            Array.Sort(sayilar);
            int[] ilkUcEleman = new int[3];
            for (int i = 0; i < 3; i++)
            {
                ilkUcEleman[i] = sayilar[i];
            }
            int[] sonUcEleman = new int[3];
            for (int i = 19; i >16; i--)
            {
                sonUcEleman[19-i] = sayilar[i];
            }
            int ilkUcSayiTop = 0;
            int sonUcSayiTop = 0;

            for (int i = 0; i < 3; i++)
            {
                ilkUcSayiTop += ilkUcEleman[i];
                sonUcSayiTop += sonUcEleman[i];
            }

            int ilkUcSayiOrt = ilkUcSayiTop / 3;
            int sonUcSayiOrt = sonUcSayiTop / 3;
            Console.WriteLine("Girilen en küçük üç sayının ortalaması : " + ilkUcSayiOrt);
            Console.WriteLine("Girilen en büyük üç sayının ortalaması : " + sonUcSayiOrt);
            Console.WriteLine($"İki ortalamanın toplamı {ilkUcSayiOrt + sonUcSayiOrt} ");




        }

        static void Soru3()
        {
            ArrayList  sesli = new ArrayList();
            string cumle = Console.ReadLine();
            char[] dizi = cumle.ToCharArray();
            
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == 'a' || dizi[i] == 'e' || dizi[i] == 'ı' || dizi[i] == 'i' || dizi[i] == 'o' || dizi[i] == 'ö' || dizi[i] == 'u' || dizi[i] == 'ü')
                {
                    sesli.Add(dizi[i]);
                }
            }
            sesli.Sort();
            Console.WriteLine("\nMetindeki Sesli Harfler sırası ile :");
            foreach (var item in sesli)
            {
                Console.Write("   "+item);
            }

        }
    }
}
