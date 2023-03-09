using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{

    //1.İŞLEM
    class Product// classımız product ve bu classda ürüne ait özelikler veriyoruz
    {//entityy varlık isimleri Product

        //snippet işlemi prop gibi hazır kodlara verilen isimlerdir.
        public int Id{ get; set; }//ürünün Idsi birincil Id primerykey

        public int CategoryId { get; set; }//ürünün hangi kategoride olduğu .kod okunurluğu için bunu ıd altına yazarız 
        
        public string ProductName { get; set; }//ürünün adı

        public double UnitPrice { get; set; }//ürünü fiyatı
         
        public int UnitsInStock  { get; set; }//ürünün stok adedi


        //CRUD operasyonları

        //create eklemek 
        //Read okumak
        //Update Güncellemek
        //delete silmek 



    }
}
