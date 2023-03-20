using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager//Buşekilde IkrediManager yazdıktan sonra ampülden Implamente ettik
    {//bunu yaptıktan sonra bütün herkes kendi kurallarına göre doldurur. hesaplarını yapabilir.
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
