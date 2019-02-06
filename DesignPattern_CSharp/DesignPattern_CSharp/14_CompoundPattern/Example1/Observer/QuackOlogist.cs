using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example1
{
    /// <summary>
    /// 呱呱叫学家，观察呱呱叫的对象
    /// </summary>
    public class QuackOlogist : IQuackObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine("QuackOlogist: " + duck + " just quacked");
        }
    }
}
