using DesignPatterns.Utils;
using System;


namespace DesignPatterns.FactoryMethod
{
    class Program
    {
        private const int IDENTATION_LEVEL = 4;
        private static Log log = new Log();

        private static ICar c1;
        private static ICar c2;


        static void Main(string[] args)
        {
            logSection("DESIGN PATTERNS: FACTORY METHOD\n");

            logSection("1. Instantiating object c1: popular car...");
            c1 = CarFactory.MakeCar(CarSophisticationLevel.Popular);
            logObjectState(nameof(c1), c1);

            log.AppendLine();

            logSection("2. Instantiating object c2: luxury car...");
            c2 = CarFactory.MakeCar(CarSophisticationLevel.Luxury);
            logObjectState(nameof(c2), c2);

            logFlush();

            waitForKeyPress();
        }


        private static void waitForKeyPress()
        {
            Console.ReadLine();
        }


        private static void logSection(string sectionName)
        {
            log.AppendLine(sectionName);
        }


        private static void logObjectState(string carObjName, ICar carObj)
        {
            log.AppendLine(IDENTATION_LEVEL, $"\t{carObjName}: {carObj.GetType().Name}");
            
            IEngine engine            = carObj.GetEngine();
            string  engineDescription = engine.GetDescription();

            IShift  shift             = carObj.GetShift();
            string  shiftDescription  = shift.GetDescription();


            log.AppendLine(IDENTATION_LEVEL, $"\t\tEngine = {engineDescription}");
            log.AppendLine(IDENTATION_LEVEL, $"\t\tShift  = {shiftDescription}");
        }


        private static void logFlush()
        {
            Console.WriteLine(log.Flush());
        }
    }
}
