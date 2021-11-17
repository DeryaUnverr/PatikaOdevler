using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Dictionary";
            Dictionary<string,int> sozluk = new Dictionary<string, int>();
            sozluk.Add("derya",25);
            sozluk.Add("fazıl",22);
            sozluk.Add("ahmet",17);
            sozluk.Add("duygu",35);

           
            Console.WriteLine("--dictionary elemanlarına erişim:--");
            Console.WriteLine(sozluk["derya"]);
            foreach (var item in sozluk)
            {
                Console.WriteLine(item);   
            }

            Console.WriteLine("--Count--");
            Console.WriteLine(sozluk.Count);

            Console.WriteLine("Contains");
            Console.WriteLine(sozluk.ContainsKey("derya"));
            Console.WriteLine(sozluk.ContainsValue(25));

            Console.WriteLine("Remove");
            sozluk.Remove("derya");
            foreach (var item in sozluk)
            {
                Console.WriteLine(item.Key);
            }
            
            foreach (var item in sozluk)
            {
                Console.WriteLine(item.Value);
            }


            Console.ReadKey();

        }
    }
}
