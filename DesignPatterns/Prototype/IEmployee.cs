using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface IEmployee
    {
        IEmployee Clone();
        string GetDetails();
    }
}
