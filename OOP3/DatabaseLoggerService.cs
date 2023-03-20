using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService //İntarfeca methodlarında sadece imza olur içi dolu olamaz.
    {
        public void Log()
        {
            Console.WriteLine("Weri tabanına Loglandı ");
        }
    }







}
