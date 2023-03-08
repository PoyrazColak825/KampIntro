using System;

namespace MusteriSimulasyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriOzellik musteri1 = new MusteriOzellik();
            musteri1.Id = 1;
            musteri1.Name = "Poyraz";
            musteri1.Surname = "Çolak";
            musteri1.CreditType = "İhtiyaç Kredisi";
            musteri1.AccountNumber = 02882828;


            MusteriOzellik musteri2 = new MusteriOzellik();
            musteri2.Id = 2;
            musteri2.Name = "Gonca";
            musteri2.Surname = "Şener";
            musteri2.CreditType = "Ev Kredisi";
            musteri2.AccountNumber = 1445528;


            MusteriOzellik musteri3 = new MusteriOzellik();
            musteri3.Id = 3;
            musteri3.Name = "Engin";
            musteri3.Surname = "Kaya";
            musteri3.CreditType = "Acil Kredisi";
            musteri3.AccountNumber = 78445528;


            MusteriOzellik[] musteriler = new MusteriOzellik[] { musteri1, musteri2, musteri3 };

            foreach (MusteriOzellik musteri in musteriler)
            {

                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Name);
                Console.WriteLine(musteri.Surname);
                Console.WriteLine(musteri.CreditType);
                Console.WriteLine(musteri.AccountNumber);


                Console.WriteLine("*************");
                // 1. işlem tek tek gelen müşterileri foreach ile sıralıyoruz.

            }




            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri1);//Add ile musteri1 atıyoruz 
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.Delete(musteri3);

            musteriManager.List(musteriler);


            //Classlar 1.olarak özellik tuttarlar.  Property -Özellik 
            //classlar 2.olarak Manager  operasyon tutuyor demektir.






















        }
    }
}
