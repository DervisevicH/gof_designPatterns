using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public abstract class Approver
    {
        public Approver NextApprover;
        public abstract void ApproveLeave(int numberOfLeaves);
        public void SetNextApprover(Approver nextApprover)
        {
            NextApprover = nextApprover;
        }
        protected abstract bool CanApprove(int numberOfLeaves);
    }
}
