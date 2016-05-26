using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract_Factory
{
    public class FactoryProducer<T, P>
        where T : BaseFactory<P>
        where P : IProduct
    {
        public T GetFactory()
        {
            //Type[] tps = null;
            //Assembly ass = Assembly.GetEntryAssembly();
            //Assembly[] refass = ass.GetReferencedAssemblies();
            //var t = Assembly.GetEntryAssembly().GetReferencedAssemblies().Select(x => Assembly.Load(x)).SelectMany(x => x.GetTypes()).First(x => x.FullName == typeof(T).FullName);

            //foreach (var item in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            //{
            //    var tp = Assembly.Load(item).GetTypes().Where(t => t.IsGenericTypeDefinition).FirstOrDefault(x => x == typeof(T).GetGenericTypeDefinition());
            //}

            T factory = Activator.CreateInstance<T>();
            return factory;
        }
    }
}
