using System;

namespace RefveOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ref ve Out ile tüm veri türlerini referans yoluyla metotlara aktarabiliriz.
            //Aralarındaki fark Out kullanacağımız değerin ilk değerini vermek zorunda değiliz. 

            int x = 100;
            int y;

            Console.WriteLine(RefileDeger(ref x));
            Console.WriteLine(OutileDeger(out y));



            static int RefileDeger(ref int x)
            {
                x = 10;
                return x;
            }

            static int OutileDeger(out int y)
            {
                y = 5;
                return y;
            }

            // Çıktı olarak 10 ve 5 dönecektir.
        }
    }
}
