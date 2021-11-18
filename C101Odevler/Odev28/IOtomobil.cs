using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev28
{
    public interface IOtomobil
    {
        // sabit bilgiler için enum kullanmalıyız 
        int KacTekerlektenOlusur();
        Marka HangiMArkanınAracı();//sabit
        Renk StandartRengiNe();//sabit

    }
}
