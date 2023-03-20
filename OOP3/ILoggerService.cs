using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ILoggerService //ILoggerManager da yazılabilir
    {//Loglama Logger service ; Projemizde loglama yapmak istiyorsak kim ne zaman hangi operasyonu çağırmasıdır.
     //Loglama farklı yöntemlerle olabilir dosya, veritabanı, sms...Birisi bir kredi başvuru yaptığında ona sms gitmeside bir loglamadır.Hepsinin imzası aynı dosyaya,veri tabanına,mail,sms kodları yazılması gerekir.
     //
        void Log();//Parametreler aalabilir.Örneğin şuan ben veritabanına Log yazmak istiyorum.
        

    
    
    
    
    
    
    }
}
