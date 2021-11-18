using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev25;

namespace Odev26
{
    public class Bitkiler:Canlilar
    {
        protected void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler Fotosentez Yapabilir.");
        }
    }

    public class TohumluBitki:Bitkiler
    {
        public TohumluBitki()
        {
            base.FotosentezYapmak();
            base.Bosaltim();
            base.Solunum();
            base.Beslenme();
           
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("TohumluBitki TohumlaCogalma Çoğalır.");
        }
    }
    public class TohumsuzBitki:Bitkiler
    {
        public TohumsuzBitki()
        {
            base.FotosentezYapmak();
            base.Bosaltim();
            base.Solunum();
            base.Beslenme();

        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("TohumsuzBitki Sporla Çoğalır.");
        }
    }
}
