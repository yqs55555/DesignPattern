using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.StatePattern.Example1
{
    [Serializable]
    public class SoldState : IState
    {
        [NonSerialized]
        private GumballMachine m_machine;

        public SoldState(GumballMachine machine)
        {
            m_machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public void Dispense()
        {
            m_machine.ReleaseBall();
            if (m_machine.BallsCount > 0)
            {
                m_machine.CurrentState = m_machine.NoQuarterState;
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                m_machine.CurrentState = m_machine.SoldOutState;
            }
        }

        public void Refill(int refillNums)
        {
            this.m_machine.BallsCount += refillNums;
        }
    }
}
