using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, LastName = "Poyraz", FirstName = "Çolak", City = "İstanbul" };

            Customer customer3 = new Customer();
            customer3.Id = 4;
            customer3.LastName = "Poyraz";
            customer3.FirstName = "Çolak";
            customer3.City = "Uşak";




            Customer customer2 = new Customer(2, "Poyraz", "ÇOLAK", "ANKARA");



            Method(3, "Poyraz", "Çolak", "Isparta");

            Console.WriteLine(customer2.FirstName);


        }

        static void Method(int Id, string Firstname, string LatName, string City)
        {

        }
        
        


    }



}
    

    class Customer
    {
        //customer1 ise buna göre çalıştı.OverLoding deniniyor.Parametre vermediğimiz için
        //Parametresi olmayan constractera defult constracter denir.
        public Customer()
        {

        }



        //customer2 buna göre çalıştı
        //Method parametreleri Camel Case yazılır.
        //sınıfı newlediğimiz de çalışan kodlar varsa onları oraya koyuyoruuz 
        public Customer(int id, string firstname, string lastName, string city)//ctor tab tab
        {
        Id = id;
        FirstName = firstname;
        LastName = lastName;
        City = city;
        }




        public int Id { get; set; }

        public string FirstName { get; set; }


        public string LastName { get; set; }

        public  string City { get; set; }

    }




















