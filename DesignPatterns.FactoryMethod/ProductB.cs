namespace DesignPatterns.FactoryMethod
{
    public class ProductB : IProduct
    {
        private const string  DESCRIPTION = "Product of Type B";
        private const decimal PRICE       = 20;

        public string GetDescription() => DESCRIPTION;

        public decimal GetPrice() => PRICE;
    }
}
