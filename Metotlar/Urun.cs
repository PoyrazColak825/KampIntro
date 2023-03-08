using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar//metotlara class ekleme 
{
    class Urun
    {
        public int Id { get; set; }//özellik proptabtab

        public string Adi { get; set; }

        public double Fiyati { get; set; }

        public string Aciklama { get; set; }//bir sürü elimiz de ürün olsa tek tek manuel olarak yazmak string ve int türünde ve ayrı ayrı her biri için dizi oluşturmak
    
        public int StokAdeti { get; set; }
    
    
    
    }
}
