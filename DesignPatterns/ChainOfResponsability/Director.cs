using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Director: Approver
    {
        public override void ApproveLeave(int numberOfLeaves)
        {
            //Omitted for simplicity, Same as TeamLead class          
        }

        protected override bool CanApprove(int numberOfLeaves)
        {
            if (numberOfLeaves > 15 && numberOfLeaves <= 20)
            {
                return true;
            }
            return false;
        }
    }
}

