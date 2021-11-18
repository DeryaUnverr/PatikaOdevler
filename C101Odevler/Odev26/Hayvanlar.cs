using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Odev26
{
    public class Hayvanlar:Canlilar
    {
        protected void AdaptasyonKurmak()
        {
            Console.WriteLine("Hayvanlar Adaptasyon Kurabilir.");
        }

    }

    public class Surungenler:Hayvanlar
    {
        public Surungenler()
        {
            base.AdaptasyonKurmak();
            base.Bosaltim();
            base.Solunum();
            base.Beslenme();
        }
        public void SurunerekHareketEt()
        {
            Console.WriteLine("Surungenler Surunerek HareketEt Edebilir..");
        }
    }
    public class Kuslar:Hayvanlar
    {
        public Kuslar()
        {
            base.AdaptasyonKurmak();
            base.Bosaltim();
            base.Solunum();
            base.Beslenme();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar Uçar..");
        }
    }
}
