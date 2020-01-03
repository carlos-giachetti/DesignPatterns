namespace DesignPatterns.AbstractFactory
{
    public interface ICarFactory
    {
        Engine MakeEngine();
        Shift  MakeShift();
    }
}
