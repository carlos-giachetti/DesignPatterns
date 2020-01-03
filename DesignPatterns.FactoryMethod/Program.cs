using DesignPatterns.Utils;
using System;


namespace DesignPatterns.FactoryMethod
{
	class Program
	{
		private const  int IDENTATION_LEVEL = 4;
		private static Log log              = new Log();

		private static IProduct product;


		static void Main(string[] args)
		{
			logSection("DESIGN PATTERNS: FACTORY METHOD");


			product = FactoryMethod.MakeProduct(ProductType.TypeA);
			logProductState();

			product = FactoryMethod.MakeProduct(ProductType.TypeB);
			logProductState();

			product = FactoryMethod.MakeProduct(ProductType.TypeC);
			logProductState();


			logFlush();
		}


		private static string getProductDetails(string objectName, string className, IProduct obj) => $"{className} {objectName}\n\t\tDescription = {obj.GetDescription()}\n\t\tPrice = {obj.GetPrice()}";


		private static void logSection(string sectionName)
		{
			log.AppendLine(sectionName);
		}


		private static void logProductState()
		{
			log.AppendLine(IDENTATION_LEVEL, "\n\t" + getProductDetails(nameof(product), product.GetType().Name, product));
		}


		private static void logFlush()
		{
			Console.WriteLine(log.Flush());
			Console.ReadLine();
		}
	}
}
