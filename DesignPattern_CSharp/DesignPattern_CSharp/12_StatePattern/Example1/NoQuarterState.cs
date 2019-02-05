using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.StatePattern.Example1
{
    [Serializable]
    public class NoQuarterState : IState
    {
        [NonSerialized]
        private GumballMachine m_machine;

        public NoQuarterState(GumballMachine machine)
        {
            m_machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            m_machine.CurrentState = m_machine.HasQuarterState;
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void Refill(int refillNums)
        {
            this.m_machine.BallsCount += refillNums;
        }
    }
}
