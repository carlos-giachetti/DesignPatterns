namespace DesignPatterns.Decorator
{
    public class ProductWithFeatureA : ProductWithDecoration
    {
        private const string  FEATURE_A_DECORATION      = " with Feature A";
        private const decimal FEATURE_A_PRICE_INCREMENT = 2;


        public ProductWithFeatureA(IProduct decoratedProduct) : base(decoratedProduct)
        {
            // Do nothing
        }


        override public string GetDescription() => base.GetDescription() + FEATURE_A_DECORATION;

        override public decimal GetPrice() => base.GetPrice() + FEATURE_A_PRICE_INCREMENT;
    }
}
