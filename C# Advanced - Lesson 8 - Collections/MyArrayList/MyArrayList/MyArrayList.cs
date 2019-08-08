using System;
using System.Collections.Generic;
using System.Text;

namespace MyArrayList
{
    class MyArrayList<T>
    {
        private const int BLOCK_SIZE = 10;
        private int _elementCount;
        private T[] _array;

        public int Count
        {
            get
            {
                return _elementCount;
            }
        }

        public MyArrayList()
        {
            _elementCount = 0;
            _array = new T[BLOCK_SIZE];
        }

        public void Add(T item)
        {
            _array[_elementCount] = item;
            _elementCount++;

            if (_array.Length == _elementCount)
            {
                ResizeArray();
            }
        }

        private void ResizeArray()
        {
            T[] tmpArray = new T[_array.Length + BLOCK_SIZE];

            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }

            _array = tmpArray;
        }

        public T Get(int index)
        {
            if (index >= 0 && index < _elementCount)
            {
                return _array[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index was out of bound of the array. Index received was " + index + " while array size is " + (_elementCount - 1));
            }
            
        }

        public void Insert(int index, T item)
        {
            if (index >= 0 && index < _elementCount)
            {
                for (int i = _elementCount; i >= index; i--)
                {
                    _array[i + 1] = _array[i];
                }

                _array[index] = item;

                _elementCount++;
                if (_array.Length == _elementCount)
                {
                    ResizeArray();
                }
            }
            else
            {
                throw new IndexOutOfRangeException("Index was out of bound of the array. Index received was " + index + " while array size is " + (_elementCount - 1));
            }
        }
    }
}
