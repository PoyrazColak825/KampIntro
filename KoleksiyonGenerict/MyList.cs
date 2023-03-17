using System;
using System.Collections.Generic;
using System.Text;

namespace KoleksiyonGenerict
{
    class MyList<T>
    {
        T[] MyArray;
        T[] GeciciArray;
        public MyList()//yapıcı metod kullandık
        {
            MyArray = new T[0];
        }
        public void Add(T item)
        {
            T[] GeciciArray = MyArray;
            MyArray = new T[MyArray.Length + 1];//eleman sayısını bir artırdı.Ama bu özellik eksik birşey daha eklemek lazım
            //for döngüsü ile GeciciArray de ki elemanları MyArray a aktarcaz

            for (int i = 0; i < GeciciArray.Length; i++)
            {
                MyArray[i]= GeciciArray[i];
            }

           MyArray[MyArray.Length - 1] = item;//dizinin son elemanına erişmek için kullanılır
        
        
        
        
        }



        // array eleman sayısını bulmak istersek
        //propfull tab tab
        public int Count
        {
            get { return MyArray.Length; }
           
        }






    }
}
