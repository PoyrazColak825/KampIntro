using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Tuzel musteri-Coorporate
    //miras- inheritance diyoruz
    //Tüzel müşteriyi : musteriye atacaz 
    //musteri de olan özelikler gercekde de tuzelde de vardır.
    //Tuzel musteri instens yada inheritance musteri ise miras 
    //tuzel ve gerçek musterinin ebeveyni musteridir 
    class TuzelMusteri:Musteri
    {
    

       

        public string SirketAdi { get; set; }

        public string VergiNo { get; set; }
    }
}
