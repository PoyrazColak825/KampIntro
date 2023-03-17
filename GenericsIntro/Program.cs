using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //3.İŞLEM
            MyList<string> isimler = new MyList<string>();

            //Örneğin Product deseydik product şeklinde bir liste olurdu.
            isimler.Add("Poyraz");



            MyList<int> isimler1 = new MyList<int>();
            isimler1.Add(2);
       
            //Olay bu metodumuz var ama bunu hafızada tuttacak birşey yok bunu nasıl yapabiliriz
            //List arka planda aslında bir tane arryi yönetiyor.
            //bizde bir tane Arry yazıp o arrryi yöneteceğiz
        
        
        
        
        }
    }
}
