using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract_Factory.Concrete_Factory
{
    public class ProductMapper : DynamicObject, IProductMapper
    {

        private IDictionary<string, BaseProductInfo> properties = new Dictionary<string, BaseProductInfo>()
        {
            { "a", new BaseProductInfo() { ProductKey = "a", ProductType = typeof(Product1) } },
            { "b", new BaseProductInfo() { ProductKey = "b", ProductType = typeof(Product2) } }
        };


        public IEnumerable<string> GetInternalProductKeys()
        {
            return properties.Keys.AsEnumerable();
        }

        public IEnumerable<BaseProductInfo> GetInternalProductsInfo()
        {
            foreach (var item in GetInternalProductKeys())
            {
                yield return properties[item];
            }

        }


        //public dynamic Expando { get { return (ExpandoObject)properties; } }


        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return properties.Keys;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (properties.ContainsKey(binder.Name))
            {
                result = properties[binder.Name];
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        //public override bool TrySetMember(SetMemberBinder binder, object value)
        //{
        //    if (map.ContainsKey(binder.Name))
        //    {
        //        map[binder.Name] = value;
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}
