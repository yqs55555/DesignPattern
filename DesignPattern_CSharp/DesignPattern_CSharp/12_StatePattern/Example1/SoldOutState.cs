using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.StatePattern.Example1
{
    [Serializable]
    public class SoldOutState : IState
    {
        [NonSerialized]
        private GumballMachine m_machine;

        public SoldOutState(GumballMachine machine)
        {
            m_machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void Refill(int refillNums)
        {
            this.m_machine.BallsCount += refillNums;
            if (this.m_machine.BallsCount > 0)
            {
                m_machine.CurrentState = m_machine.NoQuarterState;
            }
        }
    }
}
