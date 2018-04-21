using StatePattern;
using System;

namespace StatePatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
