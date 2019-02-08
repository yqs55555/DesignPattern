using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPattern_CSharp.CompoundPattern.Example1;
using DesignPattern_CSharp.CompoundPattern.Example2;

namespace DesignPattern_CSharp.CompoundPattern
{
    public class Test
    {
        public static void Example1()
        {
            DuckSimulator simulator = new DuckSimulator();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();

            simulator.Simulate(duckFactory);
        }

        public static void Example2()
        {
            IBeatModel model = new BeatModel();
            IController controller = new BeatController(model);
            controller.SetBPM(0);
        }
    }
}
