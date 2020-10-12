using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Nokia1600: INormalPhone
    {
        public string GetModelDetails()
        {
            return "Model: Nokia 1600\nRAM: NA\nCamera: NA\n";
        }
    }
}
