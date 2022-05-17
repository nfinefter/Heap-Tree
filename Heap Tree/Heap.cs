using System;
using System.Collections.Generic;
using System.Text;

namespace Heap_Tree
{
    class Heap<T>
    {
        public void Insert(T item, T[] items)
        {
            T[] newItems = new T[items.Length + 1];
            newItems = items;
            newItems[items.Length] = item;
        }
        public void HeapifyUp()
        {

        }
        public void HeapifyDown()
        {

        }
    }
}
