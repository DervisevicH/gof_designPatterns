using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class SaladProvider : ISaladProvider
    {
        public void GetChickenSalad()
        {
            Console.WriteLine("Getting Chicken Salad.");
        }

        public void GetMexicanSalad()
        {
            Console.WriteLine("Getting Mexican Salad.");

        }
    }
}
