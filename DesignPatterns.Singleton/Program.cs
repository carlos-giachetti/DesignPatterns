using DesignPatterns.Utils;
using System;

namespace DesignPatterns.Singleton
{
    class Program
    {
        private const  int IDENTATION_LEVEL = 4;
        private static Log log              = new Log();

        private static Singleton a = null;
        private static Singleton b = null;


        static void Main(string[] args)
        {
            logSection("DESIGN PATTERNS: SINGLETON");

            logSection("1. Instantiating object a and assigning values to its properties...");

            // a = new Singleton();  --> This would raise a compile-time error due to
            //                       --> the protection level - private - defined for
            //                       --> the constructor of the Singleton class.
            a = Singleton.MakeInstance();
            a.Name = "Product A";
            a.Quantity = 123;


            logSection("2. Instantiating object b, which is going to be the same instance as object a...");
            b = Singleton.MakeInstance();

            logObjectsState();  //--> Object b will be exactly the same as object a


            logSection("3. Assigning values to properties of object b, which will also affect object a...");
            b.Name = "Product B";
            b.Quantity = 222;

            logObjectsState();

            logFlush();
        }


        private static void logSection(string sectionName)
        {
            log.AppendLine(sectionName);
        }


        private static void logObjectsState()
        {
            log.AppendLine(IDENTATION_LEVEL, "\n\t" + Metadata.GetObjectDetails(nameof(a), a));
            log.AppendLine(IDENTATION_LEVEL, "\n\t" + Metadata.GetObjectDetails(nameof(b), b));
        }


        private static void logFlush()
        {
            Console.WriteLine(log.Flush());
            Console.ReadLine();
        }
    }
}
