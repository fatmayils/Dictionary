using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    
    class MyDictionary<T1,T2>
    {
        T1[] keyT1;
        T2[] valueT2;
        public MyDictionary()
        {
            keyT1 = new T1[0];
            valueT2 = new T2[0];
        }
        public void Add(T1 key, T2 value)
        {
            T1[] tempKey = keyT1;
            keyT1 = new T1[keyT1.Length + 1];

            T2[] tempValue = valueT2;
            valueT2 = new T2[valueT2.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keyT1[i] = tempKey[i];
            }

            for (int i = 0; i < tempValue.Length; i++)
            {
                valueT2[i] = tempValue[i];
            }
            keyT1[keyT1.Length - 1] = key;
            valueT2[valueT2.Length - 1] = value;
        }

        public int Counter()
        {

            return keyT1.Length;
        }
        public void List()
        {
            for (int i = 0; i <valueT2.Length; i++)
            {
                Console.WriteLine("key::>" +keyT1[i]+"  value::>"+valueT2[i]);
            }
            
        }
    }


}
