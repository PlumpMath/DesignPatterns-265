using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract_Factory
{
    public abstract class BaseFactory<P> where P : IProduct
    {
        public abstract P GetProduct();
        public abstract P GetProduct(BaseProductInfo product);
        public abstract IProductMapper ProductMapper { get; }
    }
}
