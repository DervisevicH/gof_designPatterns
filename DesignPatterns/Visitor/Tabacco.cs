using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Tabacco: Product
    {
        public Tabacco(double price)
        {
            this.Price = price;
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
