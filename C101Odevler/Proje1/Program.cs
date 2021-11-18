using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "♣♣♣ Telefon Rehberi Uygulaması ♣♣♣";
            string[] menuler =
            {
                "TELEFON NUMARASI KAYDET",
                "TELEFON NUMARASI SİL",
                "TELEFON NUMARASI GÜNCELLE",
                "REHBER LİSTELEME",
                "REHBERDE ARAMA",
                "ÇIKIŞ YAP"
            };
            Console.WriteLine(Arayuz.MenuOlustur(menuler));

            bool durum = true;
            List<Person> personList = new List<Person>();
            while (durum)
            {
                char secim = Console.ReadKey(true).KeyChar;
                Person person = new Person();
                switch (secim)
                {
                    case '1':
                        Console.Write("\n \t \t \t Kişi Adı: ");
                     person.FirstName = Console.ReadLine().ToUpper();
                     Console.Write("\t \t \t Kişi Soyadı: ");
                     person.LastName = Console.ReadLine().ToUpper();
                     Console.Write("\t \t \t Kişi Telefon Numarası: ");
                     person.PhoneNumaber = int.Parse(Console.ReadLine().ToUpper());
                     personList.Add(person);
                     Console.ForegroundColor = ConsoleColor.DarkGreen;
                     Console.Write("\n \n \t \t  --->  Rehbere kişi ekleme işlemi tamamlandı <---\n \n".ToUpper());
                     EkranYenile(menuler);
                        break;
                    case '2':
                        if (personList.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(" \n \t \t \tSİSTEME KAYITLI KİŞİ BULUNAMADI\n \t \tTEKRAR İŞLEM YAPABİLMEK İÇİN LÜTFEN BEKLEYİNİZ...");
                            EkranYenile(menuler);
                        }
                        else
                        {
                            Console.WriteLine(Arayuz.KisiGoruntule(personList));
                            Console.Write("\n \tsilmek istediğiniz kişiyi seçiniz!!!".ToUpper());
                            int secilenKisi2 = int.Parse(Console.ReadLine()) - 1;
                            personList.RemoveAt(secilenKisi2);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\n \tseçmiş olduğunuz kişi sistemden silinmiştir...".ToUpper());
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n \tAna  menüye dönüş için lütfen bekleyiniz . . . ".ToUpper());
                            EkranYenile(menuler);
                        }
                        break;
                    case '3':
                        if (personList.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(" \n \t \t \tSİSTEME KAYITLI KİŞİ BULUNAMADI\n \t \tTEKRAR İŞLEM YAPABİLMEK İÇİN LÜTFEN BEKLEYİNİZ...");
                            EkranYenile(menuler);
                        }
                        else
                        {
                            Console.WriteLine(Arayuz.KisiGoruntule(personList));
                            Console.Write("\n \nGüncellemek istediğiniz kişiyi seçiniz!!!".ToUpper());
                            int secilenKisi2 = int.Parse(Console.ReadLine()) - 1;
                            Console.Write("\n \t \t \t Kişi Telefon Numarası: ");
                            int yeniTelefon= int.Parse(Console.ReadLine());
                            personList[secilenKisi2].PhoneNumaber = yeniTelefon;
                            //yeniTelefon =personList[secilenKisi2].PhoneNumaber;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\n \tseçmiş olduğunuz kişinin Telefon Numarası güncellenmişitr.".ToUpper());
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n \tAna  menüye dönüş için lütfen bekleyiniz . . . ".ToUpper());
                            EkranYenile(menuler);
                        }
                        break;
                    case '4':
                        if (personList.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(" \n \t \t \tSİSTEME KAYITLI KİŞİ BULUNAMADI\n \t \tTEKRAR İŞLEM YAPABİLMEK İÇİN LÜTFEN BEKLEYİNİZ...");
                            EkranYenile(menuler);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Clear();
                            Console.WriteLine(Arayuz.KisiGoruntule(personList));
                            EkranYenile(menuler);
                        }
                        break;
                    case '5':
                        Console.Write("\n \nArama Yapmak istediğiniz işlem tipini seçiniz!!!".ToUpper());
                        Console.WriteLine("\n \n → İsim veya soyisime göre arama yapmak için: (1)");
                        Console.WriteLine("\n \n → Telefon numarasına göre arama yapmak için: (2)");
                        char islemSecim = Console.ReadKey(true).KeyChar;
                        if (islemSecim=='1')
                        {
                            Console.Write("İsim veya soyisim giriniz:");
                            string adveyaSoyad = Console.ReadLine().ToUpper();
                            
                            
                            foreach (var item in personList)
                            {
                                if (item.FirstName.Contains(adveyaSoyad) || item.LastName.Contains(adveyaSoyad))
                                {

                                    string cizgi = "\n \t╔════════════════════════════════════════════════════════╗\n \n";
                                    cizgi += $"\t  \n \t \t \t  KİŞİ ADI : {item.FirstName}\n \t\t \t  KİŞİ SOYADI : {item.LastName}\n \t\t \t  KİŞİ TELEFON NUMARASI: {item.PhoneNumaber}";
                                    cizgi += "\n\n \t╚════════════════════════════════════════════════════════╝\n";
                                    Console.WriteLine(cizgi);
                                }
                            }
                            
                           
                        }
                        else if (islemSecim == '2')
                        {
                            Console.Write("Telefon numarası giriniz:");
                            int arananTelefonNumarası = Convert.ToInt32(Console.ReadLine());

                            foreach (var item in personList)
                            {
                                if (item.PhoneNumaber==arananTelefonNumarası)
                                {

                                    string cizgi = "\n \t╔════════════════════════════════════════════════════════╗\n \n";
                                    cizgi += $"\t  \n \t \t \t  KİŞİ ADI : {item.FirstName}\n \t\t \t  KİŞİ SOYADI : {item.LastName}\n \t\t \t  KİŞİ TELEFON NUMARASI: {item.PhoneNumaber}";
                                    cizgi += "\n\n \t╚════════════════════════════════════════════════════════╝\n";
                                    Console.WriteLine(cizgi);
                                }
                            }

                        }
                        break;
                    case '6':
                        Console.WriteLine("\n \t \t  Çıkış Yapmak istediğinize emin misiniz(E/H)");
                        char cıkıs = Console.ReadKey(true).KeyChar;
                        if (cıkıs == 'E' || cıkıs == 'e')
                        {
                            durum = false;
                        }
                        else if (cıkıs == 'H' || cıkıs == 'h')
                        {
                            Console.Clear();
                            Console.WriteLine(Arayuz.MenuOlustur(menuler));

                        }
                        else
                        {
                            Console.WriteLine("\n \t Geçerli bir seçim yapmadınız!!!");
                            Console.Clear();
                            Console.WriteLine(Arayuz.MenuOlustur(menuler));
                        }
                        break;

                }
            }

        
        }
        static void EkranYenile(string[] menu)
        {

            Console.ForegroundColor = ConsoleColor.Gray;
            Thread.Sleep(3700);
            Console.Clear();
            Console.WriteLine(Arayuz.MenuOlustur(menu));
        }
    }
}
