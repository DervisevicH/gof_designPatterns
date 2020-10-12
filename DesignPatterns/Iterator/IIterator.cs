using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
   interface IIterator
    {
        int FirstItem { get;}
        int NextItem { get;}
        int CurrentItem { get;}
        bool IsDone { get;}
    }
}
