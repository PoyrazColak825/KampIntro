using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriSimulasyonu
{
    class MusteriOzellik
    {
        public int Id { get; set; } //MusteriOzellik class oluşturup proptabtab ile müşteri özelliklerini atadık.

        public string Name { get; set; }

        public string Surname { get; set; }

        public string CreditType{ get; set; }

        public int AccountNumber { get; set; }


        //Atadaığımız bu özellikleri program.cs de gelip müşteri ekliyoruz.

    }
}
