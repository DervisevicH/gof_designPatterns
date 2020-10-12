using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Bird: Animal
    {
        public Bird()
        {
            SetSound("Tweet");
            flyingType = new ItFly();
        }
    }
}
