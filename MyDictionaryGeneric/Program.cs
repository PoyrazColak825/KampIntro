using System;

namespace MyDictionaryGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
          MyDictionary<int,string> Müşteri = new MyDictionary<int, string>();
            Müşteri.Add(12, "Poyraz");
            Müşteri.Add(24, "Poyraz");
            Console.WriteLine(Müşteri.Count);
            Console.WriteLine(Müşteri);

        }
    }
}
