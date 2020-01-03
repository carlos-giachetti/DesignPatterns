namespace DesignPatterns.AbstractFactory
{
    abstract public class Engine
    {
        virtual public string GetDescription()
        {
            return "Engine";
        }
    }
}
