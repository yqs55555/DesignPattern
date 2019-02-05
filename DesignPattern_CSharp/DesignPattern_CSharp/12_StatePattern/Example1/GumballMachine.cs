using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.StatePattern.Example1
{
    public partial class GumballMachine
    {
        private IState m_soldOutState;
        private IState m_noQuarterState;
        private IState m_hasQuarterState;
        private IState m_soldState;
        private IState m_winnerState;

        private IState m_state;
        private int m_ballsCount;

        public IState SoldOutState => m_soldOutState;
        public IState NoQuarterState => m_noQuarterState;
        public IState HasQuarterState => m_hasQuarterState;
        public IState SoldState => m_soldState;
        public IState WinnnerState => m_winnerState;

        public IState CurrentState
        {
            get => m_state;
            set => m_state = value;
        }

        public int BallsCount
        {
            get => m_ballsCount;
            set => m_ballsCount = value;
        }

        public GumballMachine(int numberGumballs)
        {
            m_soldOutState = new SoldOutState(this);
            m_noQuarterState = new NoQuarterState(this);
            m_hasQuarterState = new HasQuarterState(this);
            m_soldState = new SoldState(this);
            m_winnerState = new WinnerState(this);

            this.m_ballsCount = numberGumballs;
            m_state = numberGumballs > 0 ? m_noQuarterState : m_soldOutState;
        }

        public void InsertQuarter()
        {
            this.m_state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            this.m_state.EjectQuarter();
        }

        public void TurnCrank()
        {
            this.m_state.TurnCrank();
            this.m_state.Dispense();
        }

        public void Refill(int nums)
        {
            this.m_state.Refill(nums);
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (m_ballsCount > 0)
            {
                m_ballsCount--;
            }
        }
    }
}
