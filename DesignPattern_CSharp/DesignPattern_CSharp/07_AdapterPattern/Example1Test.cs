using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.AdapterPattern.Example1
{
    public class Example1Test
    {
        public static void Test()
        {
            IDuck duck = new MallardDuck();

            ITurkey turkey = new WildTurkey();
            IDuck turkeyObjectAdapter = new TurkeyObjectAdapter(turkey);

            duck.Quack();
            duck.Fly();

            turkeyObjectAdapter.Quack();
            turkeyObjectAdapter.Fly();

            Console.WriteLine("---------------------------------------");

            IDuck turkeyClassAdapter = new TurkeyClassAdapter();

            turkeyClassAdapter.Quack();
            turkeyClassAdapter.Fly();
        }
    }
}
