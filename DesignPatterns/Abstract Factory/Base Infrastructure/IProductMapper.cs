using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract_Factory
{
    public interface IProductMapper
    {
        IEnumerable<string> GetInternalProductKeys();
        IEnumerable<BaseProductInfo> GetInternalProductsInfo();
        //dynamic Expando { get; }
    }
}
