using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface ATMState
    {
        void InsertCard();
        void EjectCard();
        void InsertPin(int pinEntered);
        void RequestCash(int cashToWithDraw);
    }
}
