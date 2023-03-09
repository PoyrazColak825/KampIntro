using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.İŞLEM
            Product product1 = new Product();//Ürünü oluşturuyoruz.
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //5.İŞLEM Üsteki ile altaki yazım şekli farklı sadece aynı işlem
            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                ProductName = "Kalem",
                UnitPrice = 200,
                UnitsInStock = 5,
                

            };




            //6.İŞLEM
            //ProductManager Add operasyonunu simüle etmeye çalışcaz 


            //PascalCase camelCase
            ProductManager productManager = new ProductManager();// ProductManager türündeki x=productManager yeni bir referans numarası almış ProductManager sol taraf steak sağ taraf hip
            //string isim  Yukarıdaki işlem ProductManager türünde productManager oluşturuyoruz hip de oluşması için newlemiz gerekiyor.

            productManager.Add(product1);//Bu ürünü ekledim ne ekleyeceğimizi ProductManagera gidip Add() Alanına ekliyoruz
         
            
            //12.İŞLEM
            Console.WriteLine(product1.ProductName);//101 
            //Kamera yazdırdı Masayı değil

            //9.İŞLEM
            int sayi = 100;
            productManager.BiseyYap(sayi);
            Console.WriteLine(sayi);
            //sayi 100 yazdırdı 99 yazdırmadı


            //Açıklaması değer tiplerde atamalar değeeri üzerinden olur sayi=100 diyip sayi yazdırdığında 100 çıkar.Gidip adresdeki değeri kamera yaptığımız için product1.ProcudtName kamera oldu
             
            //15.İŞLEM
            productManager.Topla2(7, 5);

            //16.İŞLEM

            int toplamSonucu = productManager.Topla(3, 5);//return sağ tarafta kalan yerdir ve bu değeri toplamaSonucu atıyoruz.

            Console.WriteLine(toplamSonucu * 2);
             
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    }
}
