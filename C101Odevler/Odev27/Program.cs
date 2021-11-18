using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Interface(Arayüz)";
            FileLogger fileLogger= new FileLogger();
            fileLogger.WriteLog();
            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();
            //SmsLogger smsLogger = new (); Console#define 9.0 ile yapılabilir.
            SmsLogger smsLogger = new SmsLogger();
            smsLogger.WriteLog();
            Console.WriteLine("------------------------------");
            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();



            Console.ReadLine();
        }
    }
}
