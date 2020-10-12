using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Square: IGeometry
    {
        // shape of geometry will be constant - intrinsic state
        public void GetShape()
        {
            Console.WriteLine("This is a square shape object");
        }
        // color of geometry will dependent on size - extrinsic state
        public void GetColor(int length)
        {
            if (length < 5)
            {
                Console.WriteLine("Square is filled with BLACK color");
            }
            else
            {
                Console.WriteLine("Square is filled with GREEN color");
            }
        }
    }
}
