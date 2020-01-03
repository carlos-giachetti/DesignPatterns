using DesignPatterns.Utils;
using System;


namespace DesignPatterns.Decorator
{
    class Program
    {
        private const  int IDENTATION_LEVEL    = 4;
        private static Log log                 = new Log();

        private static IProduct pStandard      = null;
        private static IProduct pWithA         = null;
        private static IProduct pWithB         = null;
        private static IProduct pWithC         = null;
        private static IProduct pWithAandB     = null;
        private static IProduct pWithAandC     = null;
        private static IProduct pWithBandC     = null;
        private static IProduct pWithAandBandC = null;


        static void Main(string[] args)
        {
            logSection("DESIGN PATTERNS: DECORATOR");

            logSection("Creating standard and decorated products...");

            makeObjects();

            logObjectsState();

            logFlush();

            waitForKeyPress();
        }

        private static void makeObjects()
        {
            pStandard      = new Product();
            pWithA         = new ProductWithFeatureA(pStandard);
            pWithB         = new ProductWithFeatureB(pStandard);
            pWithC         = new ProductWithFeatureC(pStandard);
            pWithAandB     = new ProductWithFeatureB(pWithA);
            pWithAandC     = new ProductWithFeatureC(pWithA);
            pWithBandC     = new ProductWithFeatureC(pWithB);
            pWithAandBandC = new ProductWithFeatureC(pWithAandB);
        }

        private static void waitForKeyPress()
        {
            Console.ReadLine();
        }

        private static void logSection(string sectionName)
        {
            log.AppendLine(sectionName);
        }


        private static void logObjectsState()
        {
            Action<string, IProduct> appendLine = (objName, obj) => log.AppendLine(IDENTATION_LEVEL, "\n\t" + Product.GetObjectDetails(objName, obj));

            appendLine(nameof(pStandard),      pStandard);
            appendLine(nameof(pWithA),         pWithA);
            appendLine(nameof(pWithB),         pWithB);
            appendLine(nameof(pWithC),         pWithC);
            appendLine(nameof(pWithAandB),     pWithAandB);
            appendLine(nameof(pWithAandC),     pWithAandC);
            appendLine(nameof(pWithBandC),     pWithBandC);
            appendLine(nameof(pWithAandBandC), pWithAandBandC);
        }


        private static void logFlush()
        {
            Console.WriteLine(log.Flush());            
        }
    }
}
