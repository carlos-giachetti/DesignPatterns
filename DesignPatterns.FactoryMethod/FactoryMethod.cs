namespace DesignPatterns.FactoryMethod
{
    public enum ProductType
    {
        TypeA, 
        TypeB, 
        TypeC
    }

    public static class FactoryMethod
    {
        public static IProduct MakeProduct(ProductType productType)
        {
            switch(productType)
            {
                case ProductType.TypeA:
                    return new ProductA();

                case ProductType.TypeB:
                    return new ProductB();

                case ProductType.TypeC:
                    return new ProductC();

                default:
                    return null;
            }
        }
    }
}
