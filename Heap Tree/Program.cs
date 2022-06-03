using System;

namespace Heap_Tree
{
    class Program
    {
        //Max Heap
        static void Main(string[] args)
        {
            Heap<string> items = new Heap<string>(5);

            items.Push("hi");
            items.Push("abc");
            items.Push("bye");
            items.Push("zzzzz");
            items.Push("aaaaa");
            items.Push("aaaa");

            while (items.Count > 0)
            {
                Console.WriteLine(items.Pop());
            }
        }
    }
}
