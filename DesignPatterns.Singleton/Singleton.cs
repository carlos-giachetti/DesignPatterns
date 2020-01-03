namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        private static Singleton theOnlyOneInstance = null;
        public string Name     { get; set; }
        public int    Quantity { get; set; }


        // Keep the constructor private, to block creation of new instances from external callers.
        // The only way to create an instance - by the way, the only one allowed - is through
        // a call to the static factory method "Singleton.MakeInstance()".
        private Singleton()
        {
            // Do nothing
        }

        // This static member "MakeInstance()" is a factory method that creates the only instance
        // allowed of the Singleton class. If the private attribute "theOnlyOneInstance" is null, 
        // then it allocates a new object, which is going to be the only instance allowed of the
        // Singleton class; otherwise, the factory method simply returns the already created
        // object, which is the only one valid instance of that Singleton class.
        public static Singleton MakeInstance()
        {
            if (theOnlyOneInstance == null)
            {
                theOnlyOneInstance = new Singleton();
            }

            return theOnlyOneInstance;
        }
    }
}
