using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    public class Arayuz
    {
        
        public static string MenuOlustur(string[] menuler)
        {
            string menu = "\t╔════════════════════════════════════════════════════════╗\n \n";
            for (int i = 0; i < menuler.Length; i++)
            {
                menu += $"\n \t \t \t {i + 1} ► {menuler[i]} ";

            }

            menu += "\n\n \t╚════════════════════════════════════════════════════════╝";
            return menu;
        }

        public static string KisiGoruntule(List<Person> liste)
        {
            Console.ForegroundColor = ConsoleColor.Gray;

            string cizgi = "\n \t╔════════════════════════════════════════════════════════╗\n \n";
            for (int i = 0; i < liste.Count; i++)
            {
                cizgi +=
                    $"\t {i + 1}.KİŞİ \n \t \t \t  KİŞİ ADI : {liste[i].FirstName}\n \t\t \t  KİŞİ SOYADI : {liste[i].LastName}\n \t\t \t  KİŞİ TELEFON NUMARASI: {liste[i].PhoneNumaber}";
                cizgi += "\n\n \t╚════════════════════════════════════════════════════════╝\n";
            }

            return cizgi;

        }

        


    }
}