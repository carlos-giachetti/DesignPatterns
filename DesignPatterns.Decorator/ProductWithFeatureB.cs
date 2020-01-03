namespace DesignPatterns.Decorator
{
    public class ProductWithFeatureB : ProductWithDecoration
    {
        private const string  FEATURE_B_DECORATION      = " with Feature B";
        private const decimal FEATURE_B_PRICE_INCREMENT = 4;


        public ProductWithFeatureB(IProduct decoratedProduct) : base(decoratedProduct)
        {
            // Do nothing
        }


        override public string GetDescription() => base.GetDescription() + FEATURE_B_DECORATION;

        override public decimal GetPrice() => base.GetPrice() + FEATURE_B_PRICE_INCREMENT;
    }
}
