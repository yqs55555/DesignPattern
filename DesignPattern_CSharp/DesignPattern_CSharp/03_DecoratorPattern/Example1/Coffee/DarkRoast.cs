namespace DesignPattern_CSharp.DecoratorPattern.Example1
{
    /// <summary>
    /// 深焙Coffee
    /// </summary>
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.BeverageDescription = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
