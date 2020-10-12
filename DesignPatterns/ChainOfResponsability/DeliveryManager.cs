using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class DeliveryManager: Approver
    {
        public override void ApproveLeave(int numberOfLeaves)
        {
            //Omitted for simplicity, Same as TeamLead class  
        }

        protected override bool CanApprove(int numberOfLeaves)
        {
            if (numberOfLeaves > 10 && numberOfLeaves <= 15)
            {
                return true;
            }
            return false;
        }
    }
}

