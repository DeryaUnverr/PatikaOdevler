using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Odev26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "OOP";

            TohumluBitki tohumluBitki = new TohumluBitki();
            //tohumluBitki.Beslenme();
            //tohumluBitki.Solunum();
            //tohumluBitki.Bosaltim();
          
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("--------------------");

            Kuslar martı = new Kuslar();
            //martı.Solunum();
            //martı.Beslenme();
            //martı.Bosaltim();
         
            martı.Ucmak();

            Console.WriteLine("--------------------");
            Console.ReadKey();



        }
    }
}
