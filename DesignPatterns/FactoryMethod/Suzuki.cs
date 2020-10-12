using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Suzuki: ICarSupplier
    {
        public string CarColor { get { return "Orange"; } }
        public void GetCarModel()
        {
            Console.WriteLine("Car model is Suzuki 2006");
        }
    }
}
