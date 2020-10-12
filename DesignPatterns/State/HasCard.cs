using System;

namespace DesignPatterns
{
    internal class HasCard : ATMState
    {
        private ATMMachine atmMachine;

        public HasCard(ATMMachine aTMMachine)
        {
            this.atmMachine = aTMMachine;
        }

        public void EjectCard()
        {
            Console.WriteLine("Your card is ejected.");
            atmMachine.setATMState(atmMachine.getNoCardState());
        }

        public void InsertCard()
        {
            Console.WriteLine("You can only insert one card at a time.");
        }

        public void InsertPin(int pinEntered)
        {
            if (pinEntered == 1234)
            {
                Console.WriteLine("You entered the correct PIN");
                atmMachine.correctPinEntered = true;
                atmMachine.setATMState(atmMachine.getHasPin());
            }
            else
            {
                Console.WriteLine("You entered the wrong PIN");
                atmMachine.correctPinEntered = false;
                Console.WriteLine("You card is ejected.");
                atmMachine.setATMState(atmMachine.getNoCardState());
            }
           
        }

        public void RequestCash(int cashToWithDraw)
        {
            Console.WriteLine("You have not entered your PIN.");

        }
    }
}