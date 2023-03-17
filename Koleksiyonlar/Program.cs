using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.İŞLEM
            string[] isimler = new string[] { "Poyraz", "Zeynep", "Selma" };//BURASI GERÇEK HAYATTDA DATALARDAN GELİYOR VE BİZ BU DİZİYE YENİ ELEMAN EKLEDİĞİMİZ ZAMAN PATLIYORUZ.
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            //2.İŞLEM
            isimler[4] = "Toprak";
            Console.WriteLine(isimler[3]);//Burda bize hata verdi çünkü böyle birşey yapamayız arrylerin dışına çıkamayız

            //3.İŞLEM
            //Ama bu şekilde yazabiliriz VE ÇALIŞIR.
            //New demek yeni referans adresi demektir.
            isimler = new string[4];

            isimler[4] = "Toprak";
            Console.WriteLine(isimler[3]);

            //Ama burda da şu sıkıntı çıkar 4.eleman olan toprağı yazar ama 
            //0-1-2-3.elemanlar olmayacağı için yazdıramıyoruz.
            //OLAY ŞU Kİ BU İŞLEMİ DİZİLER DE YAPAMIYORUZ VE ADRES DEĞİŞİKLİĞİ YAPTIĞIMIZ ZAMAN ELEMEMANLARI KAYBEDİYORUZN
            //DİZİLERİ GENİŞLETEMİYORUZ GENİŞLETSEK KAYBEDİYORUZ
            //BU sebeple arrylerde değilde koleksiyonlarda çalışıyoruz.
            //4 elemanlı bir arryi 5 elemanlı yapamıyoruz
            //5 elemanlı yaptığımız zamanda eski değerlerini kaybediyoruz


            List<string> isimler2 = new List<string> {"Poyraz","Zeynep","Selma" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Toprak");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
            //KOLEKSİYONLAR DA ARRYLERDE KAYBETTİĞİMİİZ DEĞERLERİ ÖNLEYEN BİR ALT YAPI VAR 




        }
    }
}
