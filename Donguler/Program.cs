 using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
      

            string kurs1 = "Temel Kurs";
            string kurs2 = "Programlama başlangıç kursu";
            string kurs3 = "c# Kursu Öğrenme";
            string kurs4 = "Java Öğrenme Kursu";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            Console.WriteLine("Sayfa sonuu");



            //Birşeyierli tekrar etmek için kullanan yapılardır.Örneğin kodlama İO sayfasında iki kursu sıralamak.
            for (int i = 1; i <= 10; i += 4)// 1 den başlayacağız ikinci kısım şartımızı sağlıyor ve i++ ise i 1 artır demektir.
                                            // 10dan küçük  olduğu sürece çalış i=i+2; Şeklinde de yazılır.
            {
                Console.WriteLine(i);
            }



            Console.WriteLine("Sayfa sonuu");

            //200 tane kursu tek tek değişkenlerle tanımlayamayız.Bu nedenle pytonda  liste yöntemi gerekiyor c# ise  strimg ifadelerde değilde 

            //dizilerde yazarak dinamik hale getiririz.Yani ARRAYLERDE DİZİLERDE TUTARIZ.
            //artık değişken string değil string arrylerdir kurslar diye bir array
            // string[] birden çok string ifadeli değişkenleri tutarız 
            //Tek tek tanımlamak yerine bir lisetede tuttuk.

            string[] kurslar = new string[] { "Temel Kurs", "Programlama başlangıç kursu" , "c# Kursu Öğrenme" , "Java Öğrenme Kursu" };
            //çoğunlukla programlama dilleri saymaya 0 dan bşlar

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);//kursların 0.elemanını ardından kursaların 2. elemanı ve 3 eleamanını yaz demekktir.//4.elemanını da yazdırcak ama şartı sağlamadığı için direk süslü parantezden çıkar 
            }

            



            Console.WriteLine("Sayfa sonuuuu");

            foreach (string kurs in kurslar)//büyük string class olan string anlamına gelir. küçük olan değişkeni
                //dizi temelli yapıları tek tek dönmeye yarıyor in kurslar (kursları tek tek dolaş demektir) 
            {
                Console.WriteLine(kurs);//kurs alyas bir takma addır.
            }







        }
    }
}
