using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Abstract";
            Console.WriteLine("------------------");
            NewFocus focus = new NewFocus();
            Console.WriteLine(focus.HangiMArkanınAracı().ToString());//enum olduğu için                                                           stringle yazdırdık.
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Console.WriteLine("-------İnterface---------");
            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMArkanınAracı().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());
            Console.WriteLine("-------Abstrcat---------");
            NewCivic newCivic = new NewCivic();
            Console.WriteLine(newCivic.HangiMArkanınAracı().ToString());
            Console.WriteLine(newCivic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(newCivic.StandartRengiNe().ToString());
            Console.WriteLine("------------------");
            NewCorolla corollo = new NewCorolla();
            Console.WriteLine(corollo.HangiMArkanınAracı().ToString());
            Console.WriteLine(corollo.KacTekerlektenOlusur().ToString());
            Console.WriteLine(corollo.StandartRengiNe().ToString());


            Console.ReadKey();
        }
    }
}
