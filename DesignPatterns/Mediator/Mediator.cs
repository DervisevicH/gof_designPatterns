using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    abstract class Mediator
    {
        public abstract void Send(string message,
     Colleague colleague);
    }
}
