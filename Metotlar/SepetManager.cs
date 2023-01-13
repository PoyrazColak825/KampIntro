using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar //Fonksiyon -Metot Bir Classın içinde birden fazla ürün olabilir.
{
    class SepetManager//sepete ürün ekleme özelliği metod
        //naming convention 
    {
        public void Ekle(Urun urun)
            //eğer bir parantez var ise metot vardır orada 
            //senin neyin ekleğini vermen lazım buda parametre demektir
        {
            Console.WriteLine("Tbrikler Sepete eklendi : "+ urun.Adi+ ":" + urun.Fiyati+":"+urun.Aciklama);
            //Burda parantez içinde bir değişme olduğu zaman 5 farklı sayfada değişme oluyor.
        }
            
            public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokadeti)
        {
            Console.WriteLine("Tbrikler Sepete eklendi : " + urunAdi + ":" + aciklama + ":" + fiyat);
        }
            
            // ayrı ayrı ekle2 deki gibi düzensiz olarak yazacağın şeyleri bir ddüzen altında yazmak kapsülleme olarak adlandırılır
    }
}
