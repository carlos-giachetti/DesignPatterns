namespace DesignPatterns.Decorator
{
    public class Product : IProduct
    {
        private const string  STANDARD_DESCRIPTION = "Standard product";
        private const decimal STANDARD_PRICE       = 10;


        public string GetDescription() => STANDARD_DESCRIPTION;

        public decimal GetPrice() => STANDARD_PRICE;


        public static string GetObjectDetails(string objectName, IProduct obj) => $"{objectName}\n\t\tDescription = {obj.GetDescription()}\n\t\tPrice = {obj.GetPrice()}";
    }
}
