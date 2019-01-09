namespace DesignPattern_CSharp.DecoratorPattern.Example1
{
    /// <summary>
    /// 浓缩Coffee
    /// </summary>
    public class Espresso : Beverage
    {
        public Espresso()
        {
            BeverageDescription = "Espresso Coffee";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
