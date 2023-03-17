using System;
using System.Collections.Generic;

namespace KoleksiyonGenerict
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler1 = new List<string> { "Poyraz", "Zeynep","Selma" };
            Console.WriteLine(isimler1[0]);
            Console.WriteLine(isimler1[1]);
            Console.WriteLine(isimler1[2]);
            isimler1.Add("Toprak");
            Console.WriteLine(isimler1[3]);
            Console.WriteLine(isimler1[0]);
            Console.WriteLine(isimler1.Count);


            MyList<string> isimler2 = new MyList<string> { };
            isimler2.Add("Büşra");
            isimler2.Add("Büşra");
            isimler2.Add("Büşra");
            isimler2.Add("Büşra");
            isimler2.Add("Büşra");
            isimler2.Add("Poyraz");
            Console.WriteLine(isimler2.Count);//eleman ekleme yapmamız gerekir 
          
        }
    }
}
