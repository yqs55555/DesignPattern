using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example1
{
    public class DuckSimulator
    {
        public void Simulate(AbstractDuckFactory duckFactory)
        {
            IQuackable redheadDuck = duckFactory.CreatRedheadDuck();
            IQuackable duckCall = duckFactory.CreatDuckCall();
            IQuackable rubberDuck = duckFactory.CreatRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            Flock flockOfDucks = new Flock();
            flockOfDucks.Add(redheadDuck, duckCall, rubberDuck, gooseDuck);

            Flock flockOfMallards = new Flock();
            IQuackable mallardDuckOne = duckFactory.CreatMallardDuck();
            IQuackable mallardDuckTwo = duckFactory.CreatMallardDuck();
            IQuackable mallardDuckThree = duckFactory.CreatMallardDuck();
            IQuackable mallardDuckFour = duckFactory.CreatMallardDuck();
            flockOfMallards.Add(mallardDuckOne, mallardDuckTwo, mallardDuckThree, mallardDuckFour);

            flockOfDucks.Add(flockOfMallards);

            Console.WriteLine("\nDuck Simulator: Whole Flock Simulation");
            Simulate(flockOfDucks);

            Console.WriteLine("\nDuck Simulator: Mallard Flock Simulation");
            Simulate(flockOfMallards);

            Console.WriteLine("\nDuck Simulator: With Observer");
            IQuackObserver quackologist = new QuackOlogist();
            flockOfDucks.RegisterObserver(quackologist.Update);
            Simulate(flockOfDucks);

            Console.WriteLine("The ducks quacked " + QuackCounter.Quacks + " times");
        }

        private void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
