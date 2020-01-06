namespace DesignPatterns.FactoryMethod
{
    public class Engine1000cc : IEngine
    {
        private const int    CC          = 1000;
        private const string DESCRIPTION = "Low-consumption engine";


        public int GetCc()
        {
            return CC;
        }


        public string GetDescription()
        {
            return DESCRIPTION;
        }
    }
}
