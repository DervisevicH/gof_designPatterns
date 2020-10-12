using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Util
    {
        public static void PrintLeaveMesage(string approver, int numberOfLeaves)
        {
            Console.WriteLine(approver + $" has approved the leave(s) applied for {numberOfLeaves} day(s)");
        }

        public static void SetNextApproverElsePrint(Approver approver, int numberOfLeaves)
        {
            if (approver.NextApprover != null)
            {
                approver.NextApprover.ApproveLeave(numberOfLeaves);
            }
            else
            {
                Console.WriteLine("Your leaves require special approval, please contact HR dept.");
            }
        }
    }
}
