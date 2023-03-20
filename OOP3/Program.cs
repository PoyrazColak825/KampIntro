using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //Entity Framework'te, veritabanındaki her bir tablo bir C# sınıfı olarak temsil edilir. Bu sınıflara "Entity" denir. Örneğin, bir "Musteri" tablosu varsa, bu tabloya karşılık gelen bir "Musteri" Entity sınıfı oluşturulur.
        static void Main(string[] args)
            // İnterfacelerde o interface implemente ettiğimiz classın referans numarasını tutailir 
        {
           // İhtiyacKrediManager
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManage
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            // KonutKrediManager
            IKrediManager  konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);//Burda neyi çağrırsak o çalışır 
            //BasvuruaManager biz IkrediManager yolladık IkrediManager ı implemente eden taşıt,konut,ihtiyaç
            //kredileri hangisini istiyorsak gönderebilirz ve onun hesaplası çalışıyor
            //Soyutlama kavramı
            //poliformizim Kavramı
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();
           // basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);//şeklinde de yazılır//loglama işlemini çoklu yapınca burası patladı 
            basvuruManager.BasvuruYap(ihtiyacKrediManager, new List<ILoggerService> { new DatabaseLoggerService(), new SmsService() });

            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() };

            basvuruManager.BasvuruYap(ihtiyacKrediManager,loggers);//üsteki gibi buşekilde yazılabilir

            //aşağıdaki işlemi bu şekilde de yazabilirsin.Bize gerekli olan referans numarası
            //basvuruManager.BasvuruYap(ihtiyacKrediManager,new DatabaseLoggerService());
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };
           // basvuruManager.krediOnBilgilendirmesiYap(krediler);

        }
    }
}
