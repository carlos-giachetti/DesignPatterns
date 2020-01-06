namespace DesignPatterns.FactoryMethod
{
    public static class CarFactory
    {
        public static ICar MakeCar(CarSophisticationLevel carSophisticationLevel)
        {
            switch (carSophisticationLevel)
            {
                case CarSophisticationLevel.Popular:
                    return new PopularCar();

                case CarSophisticationLevel.Luxury:
                    return new LuxuryCar();

                default:
                    return null;
            }
        }
    }
}
