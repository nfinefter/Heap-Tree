using System;

namespace Heap_Tree
{
    class Program
    {
        //Max Heap
        static void Main(string[] args)
        {
            Heap<Person> items = new Heap<Person>(5);

            items.Push(new Person(5, 2));
            items.Push(new Person(2, 1));
            items.Push(new Person(5, 1));
            items.Push(new Person(3, 2));

            //items.Push("hi");
            //items.Push("abc");
            //items.Push("bye");
            //items.Push("zzzzz");
            //items.Push("aaaaa");
            //items.Push("aaaa");

            while (items.Count > 0)
            {
                Console.WriteLine(items.Pop());
            }
        }
    }
}
