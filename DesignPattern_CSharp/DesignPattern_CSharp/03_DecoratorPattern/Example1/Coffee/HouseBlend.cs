namespace DesignPattern_CSharp.DecoratorPattern.Example1
{
    /// <summary>
    /// 综合Coffee
    /// </summary>
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.BeverageDescription = "House Blend Coffee";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
