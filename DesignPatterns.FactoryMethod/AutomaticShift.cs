namespace DesignPatterns.FactoryMethod
{
    public class AutomaticShift : IShift
    {
        private const string DESCRIPTION = "Automatic shift";

        public string GetDescription() => DESCRIPTION;
    }
}
