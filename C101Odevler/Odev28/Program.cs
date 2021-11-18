using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Odev28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Interface Ornek";
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMArkanınAracı().ToString());//enum olduğu için                                                           stringle yazdırdık.
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMArkanınAracı().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());

            Corollo corollo = new Corollo();
            Console.WriteLine(corollo.HangiMArkanınAracı().ToString());
            Console.WriteLine(corollo.KacTekerlektenOlusur().ToString());
            Console.WriteLine(corollo.HangiMArkanınAracı().ToString());


            Console.ReadKey();


        }
    }
}
