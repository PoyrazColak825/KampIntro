using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryGeneric
{
    class MyDictionary<TKey ,TValue>

    {
        TKey[] Array1;
        TValue[] Array2;
        TKey[] tempArray1;
        TValue[] tempArray2;

        public MyDictionary()
        {
             Array1=new TKey[0];
            Array2 = new TValue[0];
        }

        public void Add(TKey T1, TValue T2)
        {

            TKey[] tempArray1 = Array1;
            TValue[] tempArray2 = Array2;
            Array1 = new TKey[Array1.Length + 1];
            Array2 = new TValue[Array2.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                Array1[i] = tempArray1[i];
                Array2[i] = tempArray2[i];
            }

            Array1[Array1.Length - 1] = T1;
            Array2[Array2.Length - 1] = T2;


        }


  

        public int Count
        {
            get { return Array1.Length; }
           

        }


       
        





    }
}
