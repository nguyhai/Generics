using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyList<T>
    {
        private T[] _items;

        // Starts off like a property, with type T (since we are sorta making a list), and an index. 
        //We return the _items array, and the element that is mapped to that index
        public T this[int index] 
        {
            get
            {
                return _items[index];
            }
            set
            {
                _items[index] = value;
            }
        }


        public int Count { get; private set; }
        public int Capacity { get; private set; }

        public MyList()
        {
            _items = new T[2];
            Capacity = 2;
            Count = 0;
        }

        // We need an add method to populate our list. It needs to take generic arguments. The count is always the last index we are not using
        public void Add(T item)
        {
            // If the capacity hits the count, a shallow copy of the array is created. The capacity is then increased by 2. the items in the array will equal new array. 
            if (Capacity == Count)
            {
                T[]clone =(T[]) _items.Clone();
                Capacity *= 2;
                _items = new T[Capacity];

                Array.Copy(clone, 0, _items, 0, clone.Length);
            }
            _items[Count] = item;
            Count++;
        }



    }
}
