using System;

namespace StatePattern.GumballStates
{
    public class HasQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;
        private Random _randomNumber = new Random();

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You cannot insert another quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned the crank ...");
            int winner = _randomNumber.Next(10);

            if ((winner == 1) && (_gumballMachine.GetCount() > 1))
            {
                _gumballMachine.SetState(_gumballMachine.GetWinnerState());
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.GetSoldState());
            }
        }
    }
}
