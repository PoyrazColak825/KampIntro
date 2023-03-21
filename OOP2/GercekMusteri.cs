using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //İndividual
    class GercekMusteri:Musteri
    {
     


        public string TcNo { get; set; }

        public string Adi { get; set; }

        public string SoyAdi { get; set; }

        //C# programlama dilinde "inheritance" terimi, bir sınıfın başka bir sınıftan miras alınması işlemidir.
        //Bu işlem sayesinde, bir sınıfın özelliklerini başka bir sınıfa aktarabilir ve kod tekrarını önleyebilirsiniz.
        //İnheritance, OOP (Object-Oriented Programming) paradigmalarının önemli bir bileşenidir ve C# gibi birçok modern programlama dilinde kullanılır.

        // C# programlama dilinde inheritance, miras veren (base class) ve miras alan (derived class) olmak üzere iki temel bileşenden oluşur.
        // Miras veren sınıf, özellikleri ve metotları miras alan sınıf tarafından kullanılabilen sınıftır.
        // Miras alan sınıf ise, miras veren sınıfın özelliklerini ve metotlarını kullanarak kendi işlevselliğini gerçekleştirir.
        //C# programlama dilinde inheritance, kalıtım zincirleri şeklinde de olabilir.
        //Yani, bir sınıf birden fazla sınıftan miras alabilir ve bunlar birbirlerine bağımlı bir kalıtım zinciri oluşturabilirler.
        //Bu şekilde, karmaşık sınıf hiyerarşileri oluşturabilir ve kodunuzu daha anlaşılır hale getirebilirsiniz.
        //C# programlama dilinde inheritance kullanarak sınıf hiyerarşileri oluşturabilirsiniz.
        //Örneğin, hayvanlar sınıfı oluşturabilir ve bu sınıftan türeyen köpekler, kediler ve kuşlar sınıfları gibi alt sınıflar oluşturabilirsiniz.
        //Böylece, hayvanlar sınıfındaki özellikleri ve metotları tekrar kullanmanıza gerek kalmaz ve kod tekrarını önlersiniz.


    }
}
