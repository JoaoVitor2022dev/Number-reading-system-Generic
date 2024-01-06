using System;
using System.Collections.Generic;

namespace Project
{
    internal class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("Print Service is Full");
            }
            _values[_count] = value;
            _count++;
        }

        public T Fisrt()
        {
            if (_count == 0 )
            {
                throw new InvalidOperationException("PrintService is empty");

            }
            return _values[0]; 
        }

        public void Print() 
        {
            Console.Write("[");
            for (int i = 0; i <= _count; i++)
            {
                Console.Write(_values[i] + ",");
            }
            Console.Write("]");
        }
    }
}
