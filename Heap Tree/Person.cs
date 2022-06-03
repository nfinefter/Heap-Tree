using System;
using System.Collections.Generic;
using System.Text;

namespace Heap_Tree
{
    class Person : IComparable<Person>
    {
        public int FastPassLevel;
        public int LinePos;

        public Person(int fastPassLevel, int linePos)
        {
            FastPassLevel = fastPassLevel;
            LinePos = linePos;
        }

        public override string ToString()
        {
            return $"FastPass Level: {FastPassLevel}; Line Position: {LinePos}";
        }

        public int CompareTo(Person other)
        {
            if (other.FastPassLevel > FastPassLevel)
            {
                return -1;
            }
            
            if (other.FastPassLevel < FastPassLevel)
            {
                return 1;
            }
            
            if (other.LinePos < LinePos)
            {
                return -1;
            }

            if (other.LinePos > LinePos)
            {
                return 1;
            }

            return 0;
        }
    }
}
