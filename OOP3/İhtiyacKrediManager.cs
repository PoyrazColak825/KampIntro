using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class İhtiyacKrediManager : IKrediManager
    {//her bir kredinin farklı kredi oranına sabiptir
     //yani Hesapla methodu hepsinde farklı ifadelerdir
     //public void Hesapla()imza denir buna imzanın aynı olduğu ama içerisinin farklı olduğu durumlarda bace de oluşturduğumuz class ı interface  çeviririz   
        public void BiseyYap()
        {
            Console.WriteLine("Kredi hesaplandı");
        }

        public void Hesapla()
        {
            Console.WriteLine("Kredi hesaplandı");
        }
    }
}
