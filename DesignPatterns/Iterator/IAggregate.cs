using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    interface IAggregate
    {
        IIterator GetIterator();
        int this[int index] { get;set; }
        int Count { get; }
    }
}
