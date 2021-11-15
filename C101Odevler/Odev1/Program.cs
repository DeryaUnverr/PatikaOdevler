using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi Giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("SoyAdınızı Giriniz:");
            string surname = Console.ReadLine();
            Console.WriteLine($"Merhaba {name} {surname}");
            Console.ReadKey();
        }
    }
}
