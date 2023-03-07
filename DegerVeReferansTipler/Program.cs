using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);//30

            //sayısal veri tipleri olan int, decimal,bool,float double =değer tiplerdir.
            //aray ,class, interface =referans tiplerdir.
            //bellekte stack ve heap diye iki alan vardır.
            //değer tipler stack de gerçekleşir. ve baştan aşağı doğru kod sıralaması ilerlernir.
            //int[] sayilar1 dediğin zaman stack de bir değişken tanımladın
            // = new int[] dediğin anda heap de yeni bir alan oluşturdun ve değerler oraya yazılır.
            //mesela int[] sayilar1 steack de 101. numaralı değişkeni tutar artından heap de 101 numaralı bir arry tanımlanır 
            //ve { 10, 20, 30 }; bu değerler tutulur
            //int[] sayilar2 102 stack new int[] { 100, 200, 300 }; 102 heap new demek heap de yeni bir adres tutar
            //yani   sayilar1 = sayilar2; referans numarası birbirine eşit oldu yani 102 =102 oldu
            //ikisininde referans numarası aynı adrese atandı.
            //sayilar2[0] = 999; oldu ve ardından sayilar1[0] değeride 999 oldu.


            Console.WriteLine("******************");


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);//999



            int sayi = 1;
            while (sayi <= 10)
            {
                Console.WriteLine("Senden Hoşlanan bir adam var ve sana yavaş yavaş tutuluyor :) "); // On defa yazılır;
                //sayi++;

                // sayi++  eklenemezse sonsuz döngü olur
            }



        }
    }
}
