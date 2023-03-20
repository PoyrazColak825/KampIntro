using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager//Şablon görevi görüyor birisi bu interface kullanırsa o arkadaşım bu kredimanager daki o interfaceleri kullanmak zorunda
        //hesapla,BiseyYap
        //İnterfaceleri IkrediManager şeklinde yazarız 
        //İnterfaceleri genellikle operasyonel sınıflarda kullanıyoruzz           
    {
        void Hesapla();//
                       //if(kredi=="")eğer böyleyse şöyle hesapla diyip
                       //bir sürü kredi çeşidi olduğundan burası çorbaya döner 
                       //bu sebeple krediler classlarını oluşturuyoruz konutKrediManager,TasitkrediManager,
                       //ve ardındn KrediManager ı bunlara miras olarak verdik

        void BiseyYap();
        

        //Loglama Logger service ; Projemizde loglama yapmak istiyorsak kim ne zaman hangi operasyonu çağırmasıdır.
        //Loglama farklı yöntemlerle olabilir dosya, veritabanı, sms...Birisi bir kredi başvuru yaptığında ona sms gitmeside bir loglamadır.Hepsinin imzası aynı dosyaya,veri tabanına,mail,sms kodları yazılması gerekir.
        //
    }
}
