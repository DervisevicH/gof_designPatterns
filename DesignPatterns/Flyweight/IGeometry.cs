using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface IGeometry
    {
        // intrinsic state
        void GetShape();
        // extrinsic state
        void GetColor(int size);
    }
}
