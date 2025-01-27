using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_ADV01_Assignment
{
    internal class FixedSizeList<T>
    {
        private readonly T[] _items;
        private int _count;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero", nameof(capacity));

            _items = new T[capacity];
            _count = 0;
        }

        public int Capacity => _items.Length;
        public int Count => _count;

        public void Add(T item)
        {
            if (_count >= Capacity)
                throw new InvalidOperationException($"Cannot add item. List is at full capacity of {Capacity}");

            _items[_count] = item;
            _count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _count)
                throw new ArgumentOutOfRangeException(nameof(index),
                    $"Index must be between 0 and {_count - 1}. Actual index: {index}");

            return _items[index];
        }
    }
}
