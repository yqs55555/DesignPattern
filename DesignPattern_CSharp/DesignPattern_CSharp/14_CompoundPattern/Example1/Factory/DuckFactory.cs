using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example1
{
    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreatMallardDuck()
        {
            return new MallardDuck();
        }

        public override IQuackable CreatRedheadDuck()
        {
            return new RedheadDuck();
        }

        public override IQuackable CreatDuckCall()
        {
            return new DuckCall();
        }

        public override IQuackable CreatRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
