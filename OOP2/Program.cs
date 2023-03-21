using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //OOP (OBJECT-ORİENTED-PROGRAMMİNG NESNE YÖNELİMİ PROGRAMLAMA)
            //CLASSIN INSTINSINI OLUŞTURMAK İÇİN 
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Engin";
            //musteri1.SoyAdi = "Dmiroğ";
            //musteri1.Id = 1;
            //musteri1.TcNo = "45444545";
            //musteri1.MusteriNO = "4-1212112";
            //musteri1.SirketAdi = "?";
            //burada gelen müsterimiz sirket değildir ve buraya yazılacak bir değer yok
            //o sebeple bu class da gereksiz bilgi var ve hatalı bir kodlamadır. 
            //Gerçek-Tüzel bunlar ikisi de müşteri ama ikisi farklı müşteri sırf birbirine benziyor diye birbirinin yerine kullanılamazlar.,
            //SOLID YAZILIM GELİŞTİRME KURLLARINDA Kİ L BUNU SÖYLÜYOR 

            GercekMusteri musteri1 = new GercekMusteri();

            musteri1.Id = 1;
            musteri1.Adi = "engin";
            musteri1.SoyAdi = "dmiroğ";
            musteri1.TcNo = "45444545";
            musteri1.MusteriNo = "455454";


            //Kodlama.İo

            TuzelMusteri musteri2 = new TuzelMusteri();

            musteri2.Id = 2;
            musteri2.SirketAdi = "Kodlamaİo;";  
            musteri2.VergiNo = "97979";
            musteri2.MusteriNo = "455454";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            //inheritance terimi, bir sınıfın başka bir sınıftan miras alınması işlemidir.
            //Bu işlem sayesinde, bir sınıfın özelliklerini başka bir sınıfa aktarabilir ve kod tekrarını önleyebilirsiniz. İnheritance, OOP (Object-Oriented Programming) paradigmalarının önemli bir bileşenidir 
            //Musteri classı bellekte  Hem Gercekmusterinin referans değerinihemde TuzelMusterinin değerini tutyor 

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

            //Miras veren (Bace class) sınıfın onu inherid eden yani (derived class) miras alan tuzel ve gercek musterinin referansını tutabilmesi.Referans Tutucudur.

            //bace sınıfın referans tutucudur.

















        }
    }
}
