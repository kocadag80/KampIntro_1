using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class DictionaryList<T>
    {
        T[] sozcukler;

        public DictionaryList()
        {
            sozcukler = new T[0];
        }

        public void Add(T sozcuk)
        {
            T[] geciciDizi = sozcukler;
            sozcukler = new T[sozcukler.Length + 1];
            for (int i = 0; i < geciciDizi.Length; i++)
            {
                sozcukler[i] = geciciDizi[i];
            }
            sozcukler[sozcukler.Length -1] = sozcuk;
        }
        public int Length
        {
            get { return sozcukler.Length; }

        }
        public T[] Sozcukler
        {
            get { return sozcukler; }
        }
    }
}
