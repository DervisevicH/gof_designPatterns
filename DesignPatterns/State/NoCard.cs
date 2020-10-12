using System;

namespace DesignPatterns
{
    internal class NoCard : ATMState
    {
        private ATMMachine atmMachine;

        public NoCard(ATMMachine aTMMachine)
        {
            this.atmMachine = aTMMachine;
        }
        public void EjectCard()
        {
            Console.WriteLine("You didnt't enter a card.");
        }

        public void InsertCard()
        {
            Console.WriteLine("Please enter your pin");
            atmMachine.setATMState(atmMachine.getYesCardState());

        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("You have not entered your card");

        }

        public void RequestCash(int cashToWithDraw)
        {
            Console.WriteLine("You have not entered your card.");

        }
    }
}