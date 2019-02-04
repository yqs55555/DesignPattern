using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.StatePattern.Example1
{
    public class HasQuarterState : IState
    {
        private GumballMachine m_machine;
        private Random randomWinner = new Random(System.DateTime.Now.Millisecond);

        public HasQuarterState(GumballMachine machine)
        {
            m_machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            m_machine.CurrentState = m_machine.NoQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            if (randomWinner.Next(0, 10) == 0 && m_machine.BallsCount > 1)
            {
                m_machine.CurrentState = m_machine.WinnnerState;
            }
            else
            {
                m_machine.CurrentState = m_machine.SoldState;
            }
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void Refill(int refillNums)
        {
            m_machine.BallsCount += refillNums;
        }
    }
}
