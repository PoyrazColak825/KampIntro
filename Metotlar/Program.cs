using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metodlar tekrar tekrar kod bloklarını kullanmak için yazılır.Ortak kodlarımız var ise tekrar edilen kod bloklarını metod haline getirilir.
            //clean cood-best practice-dont repeat yourself(dry)
            //örneğin sepete ekle butonu her sayfada yada mail de sepete ekle butonu bulunuyor.

            Urun urun1 = new Urun();//class olduğu için newlemek gerekiyor.
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Armut";
            urun2.Fiyati = 19;
            urun2.Aciklama = "Yer Armutu";

            Urun[] urunler = new Urun[] {urun1,urun2 };//arryler bir veri tipinde istediğin kadar datayı tutan değişkenlerdir.


            foreach (Urun urun in urunler )//Urun class ismi yani veri tipimiz var da yazılabilir. urun ise 
            {
                Console.WriteLine(urun.Adi + "  :  " + urun.Fiyati+" : "+urun.Aciklama);

                Console.WriteLine("******************");
                
                
                
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);

                Console.WriteLine("******************");

                //Classlar 1.olarak özellik tuttarlar.  Property -Özellik 
                //classlar 2.olarak Manager servis DataAccses Bunlar bir operasyon tutuyor demektir.



            }

            Console.WriteLine("********Metodlar**************");

            //encapsulation
            SepetManager sepetManager = new SepetManager();//class gibi yazdık.
            sepetManager.Ekle(urun1);//imzanı ekle 
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil", 17,21);
            sepetManager.Ekle2("Elma", "Yeşil", 12,24);
            sepetManager.Ekle2("Karpuz", "Yeşil", 15,30);
            //üç farklı sepete ekle oluyor.daha sonra ürünün stok adetini ekle derse yöneim gidip ekle2 ye stok adetini tanımlanırız


        }
    }
}
