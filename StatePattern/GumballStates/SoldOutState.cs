using System;

namespace StatePattern.GumballStates
{
    public class SoldOutState : IState
    {
        private GumballMachine _gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("Gumballs sold out");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Gumballs sold out");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Gumballs sold out, please take your quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Gumballs sold out");
        }
    }
}
