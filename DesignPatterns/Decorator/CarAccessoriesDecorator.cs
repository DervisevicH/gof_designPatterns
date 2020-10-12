using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    
    public abstract class CarAccessoriesDecorator: ICar
    {
        private ICar _car;
        public CarAccessoriesDecorator(ICar car)
        {
            _car = car;
        }
        public virtual string GetDescription()
        {
            return this._car.GetDescription();
        }

        public virtual double GetCost()
        {
            return this._car.GetCost();
        }
    }
}
