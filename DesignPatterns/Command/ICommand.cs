using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface ICommand
    {
        string Name { get; }
        void Execute();
    }
}
