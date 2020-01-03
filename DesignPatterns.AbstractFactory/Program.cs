using DesignPatterns.Utils;
using System;


namespace DesignPatterns.AbstractFactory
{
    class Program
	{
        private const  int IDENTATION_LEVEL = 4;
        private static Log log              = new Log();

        private static Car c1;
        private static Car c2;


        static void Main(string[] args)
		{
            logSection("DESIGN PATTERNS: ABSTRACT FACTORY\n");

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


        private static void logObjectState(string carObjName, Car carObj)
        {
            log.AppendLine("\t" + carObjName);
            log.AppendLine(IDENTATION_LEVEL, "\t\t" + carObj.GetDescription());
        }


        private static void logFlush()
        {
            Console.WriteLine(log.Flush());
        }
    }
}
