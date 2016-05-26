using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Composite
    {
        void Caller()
        {
            BaseDocument doc = new DocumentComposite() {  docs = new List<BaseDocument>() { new DocumentA(), new DocumentB()} };
            doc.Create();
        }
    }
}
