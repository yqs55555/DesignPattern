using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example1
{
    public abstract class AbstractDuckFactory
    {
        public abstract IQuackable CreatMallardDuck();
        public abstract IQuackable CreatRedheadDuck();
        public abstract IQuackable CreatDuckCall();
        public abstract IQuackable CreatRubberDuck();
    }
}
