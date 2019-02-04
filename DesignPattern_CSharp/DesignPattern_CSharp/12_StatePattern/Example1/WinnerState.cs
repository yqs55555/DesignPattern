using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.StatePattern.Example1
{
    public class WinnerState : IState
    {
        private GumballMachine m_machine;

        public WinnerState(GumballMachine machine)
        {
            m_machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("ERROR");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("ERROR");
        }

        public void TurnCrank()
        {
            Console.WriteLine("ERROR");
        }

        public void Dispense()
        {
            Console.WriteLine("YOU'RE A WINNER! You get two gumballs for your quarter");
            m_machine.ReleaseBall();
            if (m_machine.BallsCount == 0)
            {
                m_machine.CurrentState = m_machine.SoldOutState;
            }
            else
            {
                m_machine.ReleaseBall();
                if (m_machine.BallsCount > 0)
                {
                    m_machine.CurrentState = m_machine.NoQuarterState;
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs");
                    m_machine.CurrentState = m_machine.SoldOutState;
                }
            }
        }

        public void Refill(int refillNums)
        {
            this.m_machine.BallsCount += refillNums;
        }
    }
}
