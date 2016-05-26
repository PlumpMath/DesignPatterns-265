using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    class Decorator
    {
        void Caller()
        {
            BaseDocument doc = new DocumentA();
            BaseDocument decor = new DocumentDecoratorForLogging() { doc = doc };

            decor.Create();
        }
    }
}
