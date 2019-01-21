using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CommandPattern.Example1
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No Command Execute");
        }

        public void Undo()
        {
            Console.WriteLine("No Command Undo");
        }
    }
}
