using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Iterator : IIterator
    {
        IAggregate _aggregate = null;

        int currentIndex = 0;

        public Iterator(IAggregate aggregate)
        {
            _aggregate = aggregate;
        }
        public int FirstItem {
            get
            {
                currentIndex = 0;
                return _aggregate[currentIndex];
            } 
        }

        public int NextItem {
            get
            {
                currentIndex += 1;
                if (IsDone == false)
                {
                    return _aggregate[currentIndex];
                }
                else
                {
                    return -1;
                }
            }
        }

        public int CurrentItem {
            get
            {
                return _aggregate[currentIndex];
            }
        }

        public bool IsDone {
            get
            {
                if(currentIndex < _aggregate.Count)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
