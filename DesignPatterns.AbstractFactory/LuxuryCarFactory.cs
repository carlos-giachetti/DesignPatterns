namespace DesignPatterns.AbstractFactory
{
    public class LuxuryCarFactory : ICarFactory
    {
        public Engine MakeEngine()
        {
            return new Engine1800cc();
        }

        public Shift MakeShift()
        {
            return new AutomaticShift();
        }
    }
}
