namespace DesignPatterns.FactoryMethod
{
    public class LuxuryCar : ICar
    {
        private const string  DESCRIPTION = "Luxury car";
        private const decimal PRICE       = 100000;

        private readonly IEngine engine   = new Engine1800cc();
        private readonly IShift  shift    = new AutomaticShift();


        public string GetDescription() => DESCRIPTION;

        public decimal GetPrice() => PRICE;

        public IEngine GetEngine() => engine;

        public IShift GetShift() => shift;
    }
}
