using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class SimpleProxy: ICalculate
    {
        public bool IsAuthenticated { get; private set; }
        private Subject subject = new Subject();
        public double ComplexOperation(double x, double y)
        {
            if (IsAuthenticated)
                return subject.ComplexOperation(x, y);
            else
                return 0;
        }
        public bool Authenticate(string pwd)
        {
            if (pwd == "password123")
            {
                IsAuthenticated = true;
                return true;
            }
            else
                return false;
        }
    }
}
