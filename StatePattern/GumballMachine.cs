using StatePattern.GumballStates;
using System;

namespace StatePattern
{
    public class GumballMachine : IState
    {
        private readonly IState _noQuarterState;
        private readonly IState _hasQuarterState;
        private readonly IState _soldState;
        private readonly IState _soldOutState;
        private readonly IState _winnerState;
        private IState _state;
        private int _count = 0;
      
        public GumballMachine(int numberOfGumballs)
        {
            _count = numberOfGumballs;
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _soldOutState = new SoldOutState(this);
            _winnerState = new WinnerState(this);

            if (numberOfGumballs > 0) _state = _noQuarterState;
        }

        public void Dispense()
        {
            _state.Dispense();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
        }

        public void SetState(IState state)
        {
            _state = state;
        }
      
        public IState GetState()
        {
            return _state;
        }

        internal IState GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        internal IState GetSoldState()
        {
            _soldState.Dispense();
            if (_state != _soldOutState)
                return _noQuarterState;
            return _soldOutState;
        }

        internal IState GetNoQuarterState()
        {
            return _noQuarterState;
        }

        internal IState GetSoldOutState()
        {
            return _soldOutState;
        }

        internal IState GetWinnerState()
        {
            _winnerState.Dispense();
            return _state;
        }

        internal void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out ...");
            if (_count != 0) _count -= 1;
            if (_count == 0) SetState(_soldOutState);
        }

        internal int GetCount()
        {
            return _count;
        }
    }
}
