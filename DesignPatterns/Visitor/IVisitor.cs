using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface IVisitor
    {
        public void Visit(Necessity necessityItem);
        public void Visit(Tabacco tabaccoItem);
    }
}
