namespace DesignPattern_CSharp.DecoratorPattern.Example1
{
    /// <summary>
    /// 低咖啡因Coffee
    /// </summary>
    public class Decaf : Beverage
    {
        public Decaf()
        {
            BeverageDescription = "Decaf Coffee";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
