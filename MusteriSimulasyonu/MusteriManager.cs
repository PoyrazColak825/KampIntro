using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriSimulasyonu
{
    class MusteriManager// MusteriManager classı oluşturduk ve burada operasyonlar atıyoruz.
    {
        public void Add(MusteriOzellik customer)//  MusteriManager clasının MusteriOzellikdir. customer parametredir
        {
            Console.WriteLine("Müşteri Ekleme işlemi başarılı"  +" "+ customer.Id + " " + customer.Name + " " + customer.Surname + " " + customer.CreditType + " " + customer.AccountNumber);
        }

        public void Delete(MusteriOzellik customer)

        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " " + "Sistemden Çıkarıldı");

        }


        public void List(params MusteriOzellik[] customer)//Artık List metodu MusteriOzellik(int de denebilir) türünden değişken sayıda parametre alabilir.

        {
            foreach (MusteriOzellik musteri in customer)
            {
                Console.WriteLine("Ad Soyadı:" + musteri.Name + " " + musteri.Surname + "\n" + "Id:" + musteri.Id + "\n");
            }

        }

        //

    }
}  

