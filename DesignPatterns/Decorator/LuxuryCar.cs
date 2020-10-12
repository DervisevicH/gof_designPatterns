using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class LuxuryCar: ICar
    {
        public string GetDescription()
        {
            return "Luxury Car";
        }

        public double GetCost()
        {
            return 1000000.0;
        }
    }
}
