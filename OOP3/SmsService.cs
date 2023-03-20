using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms loglandı");
        }
    }
}
