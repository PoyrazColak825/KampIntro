using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //1.İŞLEM
    class MyList<T>//ifadesi, C# dilinde generic bir sınıf tanımlamak için kullanılan bir yapıdır. Burada MyList isimli sınıfı tanımlarken, <T> ifadesi sınıfın tür parametresini belirtir. T, sınıfın tür parametresi olarak adlandırılır ve sınıfın örneklendiği yerde gerçek tür belirtilir.

                   //Örneğin, MyList<int> sınıfı örneklendiğinde, T tür parametresi int türü olarak yorumlanır.MyList<string> sınıfı örneklendiğinde ise, T tür parametresi string türü olarak yorumlanır.

                  //Generic sınıflar, farklı türler için aynı kodu kullanarak tekrar tekrar yazmamızı önler ve daha esnek bir kodlama yapmamızı sağlar.Bu sayede, özellikle koleksiyonlar gibi veri yapılarının oluşturulmasında sıklıkla kullanılır.

                   //<buraya trünü belirtiyoruz > Generics classa Type ile özel bir tipde çalışacağını söylüyorsun.
                   //String verdiğin tipde gidip int tipinde bir değer yazarsan hata verir
                   //o sebeple T yazılır yani bir tip ver bize demek oluyor.
       {
        //  4.İŞLEM

         T [] items;
        // C# dilinde items adında bir dizi değişkeni tanımladığımızı ifade eder. T[] ifadesi ise bu dizinin türünü belirtir ve T yerine kullanılacak gerçek tür, sınıfın örneklendiği yerde belirtilir.

        //Örneğin, GenericArray<int> sınıfı örneklendiğinde, T[] items ifadesi aslında bir int dizisi olarak yorumlanır.Benzer şekilde, GenericArray<string> sınıfı örneklendiğinde, T[] items ifadesi bir string dizisi olarak yorumlanır.

        //Dizinin elemanlarına erişmek için, indis numarası kullanılır.Örneğin, items[0] ifadesi, dizinin ilk elemanını temsil eder.
        //T olarak sana ne verirsem istediğin elemanın türüde odur

        //Burda yazmamamızın sebebi MyList clasısısının bütün operasyonlarının erişebilecei bir yere yazdık 
        //bu sayede tüm operasyonlar buna ulaşabilecek.
        //BU t li diziyi new lemek zorundayım eğer newlwmessem referans hatası alırım ve newlwdikten sonra 0 değerini verir

        //5.İŞLEM

        //constructor ctor tap tap YAPICI METOT ve constructor olduğunu classla aynı işlemi taşıdığı için anlarsın
        public MyList()
        {
            items = new T[0];
            //Bu, generic bir sınıf olan MyList için bir constructor'dır.

            //Yapıcı fonksiyon, items isimli bir dizi oluşturur ve bu dizi T türünden olacaktır.
               // Ancak, dizinin uzunluğu sıfır olarak belirlenmiştir.Yani, MyList sınıfından bir örnek oluşturulduğunda, items adlı dizi boş olacaktır.

              //Bu yapı, listenin boyutunu sonradan değiştirmek yerine, listeye elemanlar eklendikçe dinamik olarak büyüyen bir liste oluşturmak için kullanılabilir.

            //newlediğimiz anda çalışan bloğa constructor denir. 
        }//newledin arryi oluşturdun ve sıfırladın
        //Bir klass newlendiğinde çalışan bloğa constructor deniyor. 


        //2.İŞLEM
        public void Add(T item)  
        {
            //fadesi, C# dilinde generic bir sınıfın Add adında bir metodu tanımlamak için kullanılan bir yapıdır. Burada Add isimli metodu tanımlarken, T tür parametresi metoda aktarılan argümanların türünü belirtir.

            //public erişim belirteci, bu metodun her yerden erişilebilir olduğunu gösterir. void ise, bu metodun bir değer döndürmediğini ifade eder.

             //item ise, Add metoduna eklenecek olan elemanın kendisidir ve T türünden bir değişkendir.
             //Add metodunun görevi, item değişkenini sınıfın içindeki bir veri yapısına (örneğin, bir dizi) eklemektir.

              //Örneğin, MyList<int> sınıfı örneklendiğinde, Add metodu sadece int türünden argümanları kabul edebilir ve bu argümanları bir diziye ekler.



            // T olarak sana ne verirsem istediğin elemanın türüde odur
        {
                //7.İŞLEM
                
                T[] tempArray = items;//geçişi bir dizi oluşturduk 
                //ve elemanlarım uçmasın diye geçiçi diziye elemanları tutturuyoruz.
                
                //6.İŞLEM

                //benim dizimin elemanını  bir artırmam gerekiyor  İtems.Length bunu sağlıyor
                items = new T[items.Length + 1];
                //Bu ifade, items adlı diziyi, uzunluğu bir fazlası olan yeni bir T türünden diziyle değiştirir.

              //  Burada, items.Length ifadesi, items dizisinin mevcut uzunluğunu temsil eder.
              //  Yani, items dizisine bir eleman ekleneceği için, yeni dizinin uzunluğu, mevcut dizinin uzunluğuna bir eklenir. 
                //     Bu nedenle, items.Length + 1 ifadesi, yeni dizi uzunluğunu belirler.


                //dizinin eleman sayısını her seferinde 1 arttrdık
                //biz bu işlemi yaptığımız zaman eleman sayılarımız artıyor ama değerlerimiz kayboluyor bunu önlemek için geçiçi dizi oluşturuyoruz  

                //8.İŞLEM
                //Bu işlem geçiiçi diizi de olan verilerimi bana geri versene 
                //tampparry deki tüm elemanları items a geri aktaracam

                for (int i = 0; i < tempArray.Length; i++)
                {
                    items[i] = tempArray[i];//burada items eski değerlerine kavuştu
                }
                //Bu kod parçası, tempArray adlı bir dizideki elemanları items adlı diziye kopyalamak için bir döngü oluşturur.

               // Burada tempArray geçici bir dizi olduğundan ve items ile aynı boyutta olduğundan, tempArray adlı dizideki tüm elemanlar, sırasıyla, items adlı dizinin aynı indislerine kopyalanır.

                //Bu yapı, dizideki verileri bir diziden diğerine aktarmak için kullanılabilir.
                //Bu durumda, tempArray dizisinde saklanan geçici veriler, işlemlerin tamamlanmasından sonra silinebilir ve items dizisi güncel verileri içerecektir.






                               items[items.Length - 1] = item;
                //Burada items bir dizi değişkenidir ve items.Length ifadesi, items dizisinin eleman sayısını verir. Bu ifadeye -1 ekleyerek, son elemanın indis numarasına erişebiliriz.
                //Çünkü dizi indeksleri sıfırdan başlar. Yani bir dizinin ilk elemanı, indis numarası olarak 0'dır ve son elemanın indis numarası da eleman sayısı eksi bir olacaktır.



            }


















        }
   }    
}
