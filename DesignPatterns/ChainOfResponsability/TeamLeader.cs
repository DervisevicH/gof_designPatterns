using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class TeamLeader: Approver
    {
        public override void ApproveLeave(int numberOfLeaves)
        {
            if (CanApprove(numberOfLeaves))
            {
                Util.PrintLeaveMesage(this.GetType().Name, numberOfLeaves);
            }
            else
            {
                Util.SetNextApproverElsePrint(this, numberOfLeaves);
            }
        }

        protected override bool CanApprove(int numberOfLeaves)
        {
            if (numberOfLeaves <= 3)
            {
                return true;
            }
            return false;
        }
    }
}
