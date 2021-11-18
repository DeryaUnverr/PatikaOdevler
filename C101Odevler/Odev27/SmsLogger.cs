using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev27
{
    public class SmsLogger:ILogger
    {
        public void WriteLog()
        {
          //  throw new NotImplementedException();
          Console.WriteLine("Sms Olarak  Yazar.");
        }
    }
}
