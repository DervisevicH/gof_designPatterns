using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Aggregate : IAggregate
    {
        List<int> values = null;
        public Aggregate()
        {
            values = new List<int>();
        }
        public int this[int index] { 
            get 
            {
                if(index < Count)
                {
                    return values[index];
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                values.Add(value);
            }
        }

        public int Count {
            get
            {
                return values.Count;
            }
        }

        public IIterator GetIterator()
        {
            return new Iterator(this);
        }
    }
}
