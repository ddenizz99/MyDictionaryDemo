using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDictionary<K,V>
    {
        public K[] Key { get; set; }

        public V[] Value { get; set; }

        public int Count
        {
            get { return Key.Length; }
        }

        public MyDictionary()
        {
            Key   = new K[0];
            Value = new V[0];
        }

        public void Add(K key, V val)
        {
            K[] Tkey = Key;
            V[] Tval = Value;

            Key   = new K[Key.Length + 1];
            Value = new V[Value.Length + 1];
            for (int i = 0; i < Tkey.Length; i++)
            {
                Key[i]   = Tkey[i];
                Value[i] = Tval[i];
            }

            Key[Key.Length - 1]     = key;
            Value[Value.Length - 1] = val;
        }
    }
}
