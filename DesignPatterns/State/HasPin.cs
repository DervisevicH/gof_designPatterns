using System;

namespace DesignPatterns
{
    internal class HasPin : ATMState
    {
        private ATMMachine atmMachine;

        public HasPin(ATMMachine aTMMachine)
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
            Console.WriteLine("You already entered a card");

        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("You already entered a PIN");

        }

        public void RequestCash(int cashToWithDraw)
        {
            if(cashToWithDraw > atmMachine.cashInMachine)
            {
                Console.WriteLine("You don't have that much cash available");
                Console.WriteLine("Your card is ejected");
                atmMachine.setATMState(atmMachine.getNoCardState());

            }
            else
            {
                Console.WriteLine($"{cashToWithDraw.ToString()} is provided by the machine.");
                atmMachine.SetCashInMachine(atmMachine.cashInMachine - cashToWithDraw);

                Console.WriteLine("Your card is ejected");
                atmMachine.setATMState(atmMachine.getNoCardState());

                if(atmMachine.cashInMachine <= 0)
                {
                    atmMachine.setATMState(atmMachine.getNoCashState());
                }


            }
        }
    }
}