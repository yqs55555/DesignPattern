﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example1
{
    public interface IQuackable : IQuackObservable
    {
        void Quack();
    }
}
