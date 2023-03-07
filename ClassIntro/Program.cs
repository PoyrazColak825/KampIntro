using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();//Kurs değişkeni ile kurs1 adı altında veri oluşturduk.
            kurs1.kursAdi = "C#";
            kurs1.egitmen = "Engin demiroğ";
            kurs1.izlenmeOrani = 60;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "pyhton";
            kurs2.egitmen = "Engin demiroğ";
            kurs2.izlenmeOrani = 90;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Java";
            kurs3.egitmen = "Engin demiroğ";
            kurs3.izlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.kursAdi = "C++";
            kurs4.egitmen = "Engin demiroğ";
            kurs4.izlenmeOrani = 75;

            //string di bir önceki değişkenimiz artık kurs bizim değişkenimiz.kurs objesini tutuyoruz.
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4};

            foreach (Kurs kurs in kurslar)//buradaki kurs takma isim
            {
                Console.WriteLine(kurs.kursAdi+" : "+ kurs.egitmen+" : "+ kurs.izlenmeOrani);//önce ilk kurs1 in kurs.KursAdi,egitmeni ve İzlenme oranıı ardından kurs2 
            }


            //Ternary Operatörü Kullanımı: koşul? doğru ise burası : yanlış ise burası çalışsın
            Console.Write("[1-10] arasında sayı giriniz :");
            int sayi = int.Parse(Console.ReadLine());
            string cevap = "";
            cevap += sayi == 7 ? "Tebrikler doğru bildiniz" : "Yanlış cevap";
            Console.WriteLine(cevap);

            //// Coalescing Kullanımı
            Console.Write("Lütfen yaşınızı giriniz :");
            string yasiniz = Console.ReadLine();
            string sonuc = "";
            //Burada iki operatörü birarada kullanmış olduk 
            //Ternary kullanma amaçımız kullanıcı direkt boş geçerse stringlerde boş değer bir karakter olduğudan
            //Coalescing de bildiğiniz gibi null değer gelirse varsayılan değeri yazdırır.
            sonuc = (yasiniz == "" ? null : yasiniz) ?? "Boş geçildi.";
            Console.WriteLine("Yaşınız :" + sonuc);



            //ikiden fazla durum karşılaştırması, her durum için farklı değerlendirmeler yapacağımız zaman Switch - case kullanırız.Örn: haftanın günleri, her ay farklı bir durum olduğunda,,,

            int number=10;
            
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                case 50:
                    Console.WriteLine("Number is 50");
                    break;
                default:
                    Console.WriteLine("Number is not 10,20,50");
                    break;
            }


        }
    
    }

    class Kurs //daha önce bir tane string tanımlıyorduk yukarıda kurs diye de bir değişken tanımlıyorduk.
               //Ve burda kurs adı altında kendi veri tipimizi oluşturduk yabi kurs objemizi oluşturduk. Ve bu kursun 3 tane özelliği yani değişkeni var.
    {
        public string kursAdi { get; set; }
        
        public string egitmen { get; set; }

        public int izlenmeOrani { get; set; }

        
    }






}
