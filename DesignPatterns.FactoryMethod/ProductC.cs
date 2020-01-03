namespace DesignPatterns.FactoryMethod
{
    public class ProductC : IProduct
    {
        private const string  DESCRIPTION = "Product of Type C";
        private const decimal PRICE       = 30;

        public string GetDescription() => DESCRIPTION;

        public decimal GetPrice() => PRICE;
    }
}
