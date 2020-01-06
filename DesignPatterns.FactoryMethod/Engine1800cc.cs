namespace DesignPatterns.FactoryMethod
{
    public class Engine1800cc : IEngine
    {
        private const int    CC          = 1800;
        private const string DESCRIPTION = "High-performance engine";


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
