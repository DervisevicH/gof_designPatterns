using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class StopCommand: ICommand
    {
        public void Execute()
        {
            Console.WriteLine("I am executing StopCommand");
        }
        public string Name
        {
            get { return "Stop"; }
        }
    }
}
