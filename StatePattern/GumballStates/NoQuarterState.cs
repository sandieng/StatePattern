using System;

namespace StatePattern.GumballStates
{
    public class NoQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You have not inserted a quarter");
        }

        public void InsertQuarter()
        {         
            Console.WriteLine("You inserted a quarter");
            _gumballMachine.SetState(_gumballMachine.GetHasQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but you have not inserted a quarter");
        }
    }
}
