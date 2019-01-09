namespace DesignPattern_CSharp.DecoratorPattern.Example1
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.Beverage = beverage;
            this.BeverageSize = beverage.Size;
        }

        public override string Description => Beverage.Description + ", Mocha";

        public override double Cost()
        {
            return 0.20 + Beverage.Cost();
        }
    }
}
