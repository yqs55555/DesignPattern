using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CommandPattern.Example1
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
