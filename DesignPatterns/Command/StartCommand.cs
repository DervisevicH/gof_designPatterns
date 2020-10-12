using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class StartCommand:ICommand
    {
        public void Execute()
        {
            Console.WriteLine("I am executing StartCommand");
        }
        public string Name
        {
            get { return "Start"; }
        }
    }
}
