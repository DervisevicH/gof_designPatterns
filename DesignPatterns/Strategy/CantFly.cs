using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class CantFly: IFly
    {
        public string Fly()
        {
            return "I can't fly";
        }
    }
}
