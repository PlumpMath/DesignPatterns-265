using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    class Prototype
    {
        void Caller()
        {

            DocumentsCollection col = new DocumentsCollection();
            BaseDocument docClone = (BaseDocument)col.ToList()[0].Clone();


        }
    }
}
