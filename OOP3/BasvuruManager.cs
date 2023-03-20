using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager , List<ILoggerService>  loggerServices)//BU Başvuruuyu hangi kredi de veririz hepsinin referansını tutan IkrediManager yazdık
        {//bu kısma ister konut,taşıt , ihtiyac kredisini gönderebiliriz ve oaradaki
         //krediManager.Hesaplası();
         //hangisini gönderirsek onun hespalası çalışır
         //Başvuran Bilgilerini değerlendirme 
        
         //KonutKrediManager konutKrediManager = new KonutKrediManager();

            //hangisini gönderirsek onun hespalası çalışır
            krediManager.Hesapla();//burda bir tanesini hesaplıyoruz kredi çeşidi
                                   //BU BİLGİ ÇOK AMA ÇOK ÖNEMLİ YAZILIM HAYATIMIZIN DÖNÜM NOKTASI
                                   //bu kod çalışır ama tüm başvurlar konut kredisine göre çalşır.

            //Burada bu metodu aynı zaman da loglamak istiyorumm direk interface verdik (ILoggerService)
            //hangi Logger servis seçilmişse onu logla 

            //Method injection

            //loggerService.Log();
            //bununla birlikte biz buarada Method injection yaptık

            //Birden çok logger yapmak istersek

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }




        }


        public void krediOnBilgilendirmesiYap(List<IKrediManager> krediler)//birden fazla kredinin hesabını yapmak istiyoruz bu listenin türü IKrediManager olsun.
         {
            //Burada müşteriye uyan kaç tane kredi seçmemiz gereken kredi çeşitleriini sıralicaz
            //aynı veri türünde 0-1-10-100 veriyi tutabilen şey List dir. 

            foreach (var kredi in krediler)//listedeki her bir kredinin hesabını yap
            {
                kredi.Hesapla();//burda birden fazla krediyi hesaplıyoruz.
            }
           


         }
     
    
    
    
    
    
    
    
    
    }
}
