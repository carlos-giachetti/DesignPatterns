namespace DesignPatterns.FactoryMethod
{
    public class ProductA : IProduct
    {
        private const string  DESCRIPTION = "Product of Type A";
        private const decimal PRICE       = 10;

        public string GetDescription() => DESCRIPTION;

        public decimal GetPrice() => PRICE;
    }
}
