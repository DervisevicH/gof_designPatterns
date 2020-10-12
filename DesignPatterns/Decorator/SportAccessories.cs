using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class SportAccessories: CarAccessoriesDecorator
    {
        public SportAccessories(ICar car) : base(car) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ",Sports Accessories Package";
        }

        public override double GetCost()
        {
            return base.GetCost() + 15000.0;
        }
    }
}
