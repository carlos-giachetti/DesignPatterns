using DesignPatterns.Utils;
using System.Diagnostics;

namespace DesignPatterns.Decorator
{
    public abstract class ProductWithDecoration : IProduct
    {
        private IProduct decoratedProduct;


        public ProductWithDecoration(IProduct decoratedProduct)
        {
            Debug.Assert(decoratedProduct != null);

            this.decoratedProduct = decoratedProduct;
        }


        virtual public string GetDescription()
        {
            return decoratedProduct.GetDescription();
        }

        virtual public decimal GetPrice()
        {
            return decoratedProduct.GetPrice();
        }
    }
}
