namespace DesignPatterns.FactoryMethod
{
    public class ManualShift : IShift
    {
        private const string DESCRIPTION = "Manual shift";

        public string GetDescription() => DESCRIPTION;
    }
}
