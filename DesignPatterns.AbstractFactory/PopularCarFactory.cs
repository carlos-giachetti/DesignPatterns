namespace DesignPatterns.AbstractFactory
{
    public class PopularCarFactory : ICarFactory
    {
        public Engine MakeEngine()
        {
            return new Engine1000cc();
        }

        public Shift MakeShift()
        {
            return new ManualShift();
        }
    }
}
