using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method overload aynı isimde farklı parametrelere sahip birden fazla method tanımlanmasıdır.

            SayHello();
            SayHello("Hello World");
            SayHello("İdil", "Hello");

            Console.ReadKey();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello");
        }
        static void SayHello(string msg)
        {
            Console.WriteLine(msg);
        }
        static void SayHello(string ad, string msg)
        {
            Console.WriteLine(msg + " " + ad);
        }
    }
}
