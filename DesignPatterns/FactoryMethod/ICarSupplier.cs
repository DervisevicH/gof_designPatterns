using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface ICarSupplier
    {
        public string CarColor{ get;}
        void GetCarModel();
    }
}
