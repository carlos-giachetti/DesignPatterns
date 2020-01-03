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
			c1 = CarFactory.MakeCar(CarSophisticationLevel.Popular);
			c2 = CarFactory.MakeCar(CarSophisticationLevel.Luxury);

            logObjectsState();
            logFlush();

            waitForKeyPress();
        }


        private static void waitForKeyPress()
        {
            Console.ReadLine();
        }


        private static void logObjectsState()
        {
            log.AppendLine(nameof(c1));
            log.AppendLine(IDENTATION_LEVEL, "\t" + c1.GetDescription() + "\n");

            log.AppendLine(nameof(c2));
            log.AppendLine(IDENTATION_LEVEL, "\t" + c2.GetDescription());
        }


        private static void logFlush()
        {
            Console.WriteLine(log.Flush());
        }
    }
}
