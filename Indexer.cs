using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29
{
    class Indexer<T>
    {
        private T[] _arr = new T[5];

        public T this[int i]
        {
            get => _arr[i];
            set { _arr[i] = value; }
        }
    }
}
