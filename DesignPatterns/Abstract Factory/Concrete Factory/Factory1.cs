using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract_Factory.Concrete_Factory
{
    public class Factory1<T> : BaseFactory<T> where T : BaseProduct1
    {
        private ProductMapper mapper = new ProductMapper();


        public override T GetProduct()
        {
            if (typeof(T) == typeof(Product1))
            {
                return (new Product1()) as T;
            }
            else if (typeof(T) == typeof(Product2))
            {
                return (new Product2()) as T;
            }
            else
            {
                throw new Exception("");
            }
        }
        public override T GetProduct(BaseProductInfo product)
        {
            return Activator.CreateInstance(product.ProductType) as T;
        }


        public override IProductMapper ProductMapper { get { return mapper; } }
    }
}
