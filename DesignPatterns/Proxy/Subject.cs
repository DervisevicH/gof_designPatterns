using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Subject: ICalculate
    {
        public double ComplexOperation(double x, double y)
        {
            return x + y;
        }
    }
}
