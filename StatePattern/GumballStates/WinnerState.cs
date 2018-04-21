using System;

namespace StatePattern.GumballStates
{
    public class WinnerState : IState
    {
        private GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("You're a winner! You get 2 gumballs for your quarter");
            _gumballMachine.ReleaseBall();

            if (_gumballMachine.GetCount() == 0)
                _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
            else
            {
                _gumballMachine.ReleaseBall();
                if (_gumballMachine.GetCount() > 0)
                    _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
                else
                {
                    Console.WriteLine("Out of gumballs");
                    _gumballMachine.SetState(_gumballMachine.GetSoldOutState());
                }
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're alrady giving you a gumball");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball");
        }
    }
}
