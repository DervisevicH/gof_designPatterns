using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Dog: Animal
    {
        public Dog() { 
            SetSound("Bark");
            flyingType = new CantFly();
        }
        public void DigHole()
        {

        }
    }
}
