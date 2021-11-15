using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev14
{
    public static class DeryaExtension
    {
        public static IEnumerable<T> WhereDerya<T>(this IEnumerable<T> list, Func<T, bool> func)
        {
            List<T> YeniListe = new List<T>();
            foreach (var item in list)
            {
                if (func(item))
                {
                    YeniListe.Add(item);
                }
            }
            return YeniListe;
        }
    }

    // Recursif Metod 
    //public static int Faktoriyel(int sayi)
    //{
    //if (sayi <= 1)
    //{
    //    return 1;
    //}
    //return sayi * Faktoriyel(sayi - 1);
    //}

}

