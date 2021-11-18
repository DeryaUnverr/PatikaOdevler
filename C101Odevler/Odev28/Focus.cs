using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev28
{
    public class Focus:IOtomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Marka HangiMArkanınAracı()
        {
            return Marka.Ford;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}
