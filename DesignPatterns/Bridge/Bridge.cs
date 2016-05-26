using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    class Bridge
    {
        void Caller()
        {
            BaseDocument doc = new DocumentB() { dal = new DalThroughEF()};  
            doc.Create();
        }
    }
}
