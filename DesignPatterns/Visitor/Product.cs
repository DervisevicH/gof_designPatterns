using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public abstract class Product
    {
        public double Price { get; set; }
        public abstract void Accept(IVisitor visit);
    }
}
