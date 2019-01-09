namespace DesignPattern_CSharp.DecoratorPattern.Example1
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            this.Beverage = beverage;
            this.BeverageSize = beverage.Size;
        }

        public override string Description => Beverage.Description + ", Milk";

        public override double Cost()
        {
            return this.Beverage.Cost() + 0.10;
        }
    }
}
