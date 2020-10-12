using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Necessity: Product
    {
        public Necessity(double price)
        {
            this.Price = price;
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
