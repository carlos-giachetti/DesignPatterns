namespace DesignPatterns.AbstractFactory
{
    public class Car
    {
        public Engine Engine { get; set; }

        public Shift  Shift  { get; set; }

        public virtual string GetDescription()
        {
            return "Engine = " + Engine.GetDescription() + "; " + 
                   "Shift = "  + Shift.GetDescription();
        }        
    }
}
