using System;

namespace DesignPatterns
{
    internal class NoCash : ATMState
    {
        private ATMMachine atmMachine;

        public NoCash(ATMMachine aTMMachine)
        {
            this.atmMachine = aTMMachine;
        }

        public void EjectCard()
        {
            Console.WriteLine("We don't have any money.");
            Console.WriteLine("There is no card to eject.");

        }

        public void InsertCard()
        {
            Console.WriteLine("We don't have any money.");
            Console.WriteLine("Your card is ejected.");
        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("We don't have any money.");

        }

        public void RequestCash(int cashToWithDraw)
        {
            Console.WriteLine("We don't have any money.");

        }
    }
}