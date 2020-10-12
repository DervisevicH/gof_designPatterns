using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface IToyBuilder
    {
        void SetModel();
        void SetHead();
        void SetLimbs();
        void SetBody();
        void SetLegs();
        Toy GetToy();
    }
}
