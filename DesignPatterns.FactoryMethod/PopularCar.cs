namespace DesignPatterns.FactoryMethod
{
    public class PopularCar : ICar
    {
        private const string  DESCRIPTION = "Popular car";
        private const decimal PRICE       = 40000;

        private readonly IEngine engine   = new Engine1000cc();
        private readonly IShift  shift    = new ManualShift();


        public string GetDescription() => DESCRIPTION;

        public decimal GetPrice() => PRICE;

        public IEngine GetEngine() => engine;

        public IShift GetShift() => shift;
    }
}
