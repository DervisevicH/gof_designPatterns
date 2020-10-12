using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Visitor: IVisitor
    {
        public double TaxToPay { get; private set; }
        public double TotalPrice{ get; private set; }
    
        public void Visit(Tabacco tabacco)
        {
            double calculatedTax = (tabacco.Price * 32) / 100;
            TotalPrice += tabacco.Price + calculatedTax;
            TaxToPay += calculatedTax;
        }
        public void Visit(Necessity necessity)
        {
            double calculatedTax = (necessity.Price * 10) / 100;
            TotalPrice += necessity.Price + calculatedTax;
            TaxToPay += calculatedTax;
        }
    }
}
