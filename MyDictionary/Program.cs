using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> sehirler = new Dictionary<int, string>();
            sehirler.Add(28, "Giresun");
            sehirler.Add(16, "Bursa");
            sehirler.Add(34, "İstanbul");

            MyDictionary<int, string> sehirler2 = new MyDictionary<int, string>();
            sehirler2.Add(28, "Giresun");
            sehirler2.Add(16, "Bursa");
            sehirler2.Add(34, "İstanbul");
            sehirler2.Add(61, "Trabzon");

            foreach (var item in sehirler2.TValueItems)
            {
                Console.WriteLine(item);
            }
        }

        class MyDictionary<TKey, TValue>
        {
            TKey[] _tKey;
            TValue[] _tValue;

            public MyDictionary()
            {
                _tKey = new TKey[0];
                _tValue = new TValue[0];
            }

            public void Add(TKey tKey, TValue tValue)
            {
                TKey[] tmpArrayKey = _tKey;
                TValue[] tmpArrayValue = _tValue;

                _tKey = new TKey[_tKey.Length + 1];
                _tValue = new TValue[_tValue.Length + 1];

                for (int i = 0; i < tmpArrayKey.Length; i++)
                {
                    _tKey[i] = tmpArrayKey[i];
                }

                _tKey[_tKey.Length - 1] = tKey;

                for (int j = 0; j < tmpArrayValue.Length; j++)
                {
                    _tValue[j] = tmpArrayValue[j];
                }

                _tValue[_tValue.Length - 1] = tValue;
            }

            public int TKeyLength
            {
                get { return _tKey.Length; }
            }
            public int TValueLength
            {
                get { return _tValue.Length; }
            }

            public TKey[] TKeyItems
            {
                get { return _tKey; }
            }

            public TValue[] TValueItems
            {
                get { return _tValue; }
            }
        }
    }

}
