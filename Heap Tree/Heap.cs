using System;
using System.Collections.Generic;
using System.Text;

namespace Heap_Tree
{
    class Heap<T> where T : IComparable<T>
    {
        private T[] items;

        public void Insert(T item)
        {
            T[] newItems = new T[items.Length + 1];
            newItems = items;
            newItems[items.Length] = item;
        }
        public void HeapifyUp(int index)
        {
            if (index == 0) return;

            int parent = (index - 1) / 2;

            if (items[index].CompareTo(items[parent]) < 0)
            {
                T temp = items[parent];
                items[parent] = items[index];
                items[index] = temp;
            }
            HeapifyUp(parent);
        }
        public void HeapifyDown(int index)
        {
            int leftChild = index * 2 + 1;

            if (leftChild >= items.Length)
            {
                return;
            }

            int swapIndex = 0;
            int rightChild = index * 2 + 2;

            if (rightChild >= items.Length)
            {
                swapIndex = leftChild;
            }
            else
            {
                if (items[leftChild] != null && items[rightChild] != null)
                {
                    swapIndex = Math.Min(items[leftChild], items[rightChild]);
                }
                
            }
            if (items[swapIndex].CompareTo(items[index]) < 0)
            {
                T temp = items[index];
                items[index] = items[swapIndex];
                items[swapIndex] = temp;
            }
            HeapifyDown(swapIndex);
        }
        public T Pop()
        {
            if (items.Length == 0) throw new Exception("empty");

            T root = items[0];

            items[0] = items[items.Length - 1];

            HeapifyDown(0);
            return root;
        }
    }
}
