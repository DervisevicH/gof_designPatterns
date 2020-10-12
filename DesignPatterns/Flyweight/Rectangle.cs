using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Rectangle: IGeometry
    {
        // shape of geometry will be constant - intrinsic state
        public void GetShape()
        {
            Console.WriteLine("This is a Rectangle shape object");
        }
        // color of geometry will dependent on size - extrinsic state
        public void GetColor(int length)
        {
            if (length < 5)
            {
                Console.WriteLine("Rectangle is filled with BLUE color");
            }
            else
            {
                Console.WriteLine("Rectangle is filled with RED color");
            }
        }
    }
}
