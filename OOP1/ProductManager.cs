using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    
    class ProductManager//ürünle ilgili operasyonları atıyoruz 2.İŞLEM
    {
        //3.İŞLEM                           
        //ProductManager içindeki benim adım Add ve bana string türünde metin yolla diyorsun
        public void Add(/*7İŞLEM*/  Product product) //Bu bizim ekleme operasyonumuz ve imzamız 
         //Add (strin isim) şeklinde de yazılabilirdi. Benim türüm string ad ver 
         //public void Add(  Product product) Bana product türünde birşey ver diyoruz
        // elle yazılıyor.
        {
            //11.İŞLEM
           //product.ProductName = "Kamera";//101 
            Console.WriteLine(product.ProductName + " eklendi ");


            //biz bir ürün eklersek bu ekleme operasyonununa neyi eklememiz gerektiğini söylememşz gerekir
            
        }

        //8.İŞLEM ÖRNEK
        public void BiseyYap(int sayi)
        {
          //10.İŞLEM
            sayi = 99;
            Console.WriteLine(sayi);
        }


        //13 İŞLEM
         public void update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }

        //VOİD NE İŞE YARAR
        //EMİR KİPİNDE GİT EKLE GİT SİL ŞEKLİNCE İŞLEMİNİ GERÇEKLEŞTİRİYOR

        //14.İŞLEM

        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

         
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine( sayi1 + sayi2);
        }
         
        //voidle mi yazmak intlemi yazsak 
        //topla2 işlemini yapıyor ve bitiyor.
        //RETURN E neden ihtiyaç vardır.
        //Örneğin toplamı 2 ile çarpmak istiyorum bunu void ile yapamıyoruz
        //void emir kipi ile çalışır ve yapamaz 
        //ama return bu işlemi yapabilir işlemi 2 ile çarpar



    }
}
