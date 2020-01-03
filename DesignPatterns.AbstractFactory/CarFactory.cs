namespace DesignPatterns.AbstractFactory
{
    public static class CarFactory
    {
        public static Car MakeCar(CarSophisticationLevel carSophisticationLevel)
        {
            ICarFactory carFactory = null;

            switch(carSophisticationLevel)
            {
                case CarSophisticationLevel.Popular:
                    carFactory = new PopularCarFactory();
                    break;

                case CarSophisticationLevel.Luxury:
                    carFactory = new LuxuryCarFactory();
                    break;

                default:
                    return null;
            }

            if (carFactory == null) return null;

            return new Car
            {
                Engine = carFactory.MakeEngine(),
                Shift  = carFactory.MakeShift()
            };
        }
    }
}
