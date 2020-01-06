namespace DesignPatterns.FactoryMethod
{
    public interface ICar
    {
        string  GetDescription();

        decimal GetPrice();

        IEngine GetEngine();

        IShift GetShift();
    }
}
