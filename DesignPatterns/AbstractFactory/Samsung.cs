using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class SamsungPhone: IMobilePhone
    {
        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGalaxy();
        }
        public INormalPhone GetNormalPhone()
        {
            return new SamsungGuru();
        }
    }
}
