using System;

namespace OOP3
{
    //Şimdilik iki tane loglama servisimiz var 
    class FileLoggerService : ILoggerService //İntarfeca methodlarında sadece imza olur içi dolu olamaz.
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı ");
        }
    }







}
