using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class EconomyCar: ICar
    {
        public string GetDescription()
        {
            return "Economy car";
        }
        public double GetCost()
        {
            return 450000.0;
        }
    }
}
