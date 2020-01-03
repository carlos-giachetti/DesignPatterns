namespace DesignPatterns.Decorator
{
    public class ProductWithFeatureC : ProductWithDecoration
    {
        private const string  FEATURE_C_DECORATION      = " with Feature C";
        private const decimal FEATURE_C_PRICE_INCREMENT = 8;


        public ProductWithFeatureC(IProduct decoratedProduct) : base(decoratedProduct)
        {
            // Do nothing
        }


        override public string GetDescription() => base.GetDescription() + FEATURE_C_DECORATION;

        override public decimal GetPrice() => base.GetPrice() + FEATURE_C_PRICE_INCREMENT;
    }
}
