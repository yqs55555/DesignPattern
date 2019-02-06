using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example1
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreatMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override IQuackable CreatRedheadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public override IQuackable CreatDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public override IQuackable CreatRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
