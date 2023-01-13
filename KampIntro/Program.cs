using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)//MAİN İÇİNDE NE YAZARSA O ÇALIŞIR.CONSOLE EKRANINDA HANGİ VERİ GELİYOR HANGİ VERİ ÇALIŞIYOR ONU GÖRMEK İSTER.
        {
            //Type Safety-- Veri Güvenliği 
            //DEĞİŞKENLER VERİ TUTUCUDUR.VE BİZ VERİYİ DEĞİŞKENLERLE YÖNETİRİZ.ÖRNEĞİN STRİNG İNT 

            string kategoriEtiketi = "Kategoriler";//KategoriEtiketi bir alyas bir takma isimdir.ve kodsal bir anlamı var

            //5 kere her yere yazdın ve kategoriler olarak değiştirmek istediler ozman gidip manuel olarak her yerden değiştirme çünkü orda 
            //kendini tekrar etmişş önemli olan kendini tekrar etmemek DO NOT REPEAT  OURSELF 
            Console.WriteLine("Kategori");
            Console.WriteLine("Kategori");
            Console.WriteLine("Kategori");
            Console.WriteLine("Kategori");
            Console.WriteLine(kategoriEtiketi);//eğer kategori ismi kategoriler olacaksa gidip etiketin karşısını kategoriler olarak değiştiriyoruz.

            int ogrenciSayisi = 345000000;
            double faizOrami = 1.45;
            float dolar = 8;
            //****************************************
            //sistemem giriş yapmışmı yapmamışmı bool bu kontrolü sağlar.
            bool sistemeGirisYapmisMi = false; //BURASI BİR VERİ KAYNAĞINDAN GELECEĞİ İÇİN İF KODLARINI YAZMAK ZORUNDAYIZ.


            //İF-ELSE KOOMUTLARNDAN SADECE BİRİ ÇALIŞMAK ZORUNDADIR 

            if (sistemeGirisYapmisMi==true) //şartı sağlıyormu sağlamıyormu 
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Kullanıcı Giriş Yap");
            }





            double dolardun = 3.89;
            double dolarbugun = 3.40;

            if (dolardun>dolarbugun)
            {
                Console.WriteLine("dolar azalmıştır");

            }

            else if (dolarbugun>dolardun)
            {
                Console.WriteLine("dolar artmıştır");

            }

            else
            {
                Console.WriteLine("dolar eşittir");
            }

        




        }
    }
}
