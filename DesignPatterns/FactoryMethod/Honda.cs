using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Honda: ICarSupplier
    {
        public string CarColor{ get { return "Red"; } }
        public void GetCarModel() { Console.WriteLine("Car model is Honda 2014."); }
    }
}
