using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class ATMMachine
    {
        ATMState hasCard;
        ATMState noCard;
        ATMState hasCorrectPin;
        ATMState atmOutOfMoney;

        ATMState atmState;

        public int cashInMachine = 2000;
        public bool correctPinEntered = false;

        public ATMMachine()
        {
            hasCard = new HasCard(this);
            noCard = new NoCard(this);
            hasCorrectPin = new HasPin(this);
            atmOutOfMoney = new NoCash(this);

            atmState = noCard;
            if (cashInMachine < 0)
            {
                atmState = atmOutOfMoney;
            }
        }
        public void setATMState(ATMState newATMState)
        {
            atmState = newATMState;
        }
        public void SetCashInMachine(int newCashInMachine)
        {
            cashInMachine = newCashInMachine;
        }
        public void InsertCard()
        {
            atmState.InsertCard();
        }
        public void EjectCard()
        {
            atmState.EjectCard();
        }
        public void RequestCash(int cashToWithDraw)
        {
            atmState.RequestCash(cashToWithDraw);
        }
        public void InsertPin(int pinEntered)
        {
            atmState.InsertPin(pinEntered);
        }
        public ATMState getYesCardState() { return hasCard; }
        public ATMState getNoCardState() { return noCard; }
        public ATMState getHasPin() { return hasCorrectPin; }
        public ATMState getNoCashState() { return atmOutOfMoney; }
    }
}
