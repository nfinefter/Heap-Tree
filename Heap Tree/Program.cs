using System;

namespace Heap_Tree
{
    class Program
    {

        static void Main(string[] args)
        {
            Heap<int> items = new Heap<int>(5);

            items.Insert(5);
            items.Insert(2);
            items.Insert(3);
            items.Insert(4);
            items.Insert(1);
            items.Insert(7);
            items.Insert(9);

            //Not Displaying in correct Order
            while (items.Count > 0)
            {
                Console.WriteLine(items.Pop());
            }
        }
    }
}
