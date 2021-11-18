using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev27
{
    //ILogger ı yonetim işlemi / ana sınıf(temel log işlemi, heryerden kullanbilceğim temel birşey oluşturdum.) 
    public class LogManager:ILogger
    {
        public ILogger _Logger; //interface in instance ını oluşturuyorum
        public LogManager(ILogger logger)
        {
            _Logger = logger;
        }

        public void WriteLog()
        {
            //throw new NotImplementedException();
            _Logger.WriteLog();
        }
    }
}
