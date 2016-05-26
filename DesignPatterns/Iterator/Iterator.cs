using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    class Iterator
    {

        void Caller()
        {
            DocumentsCollection collection = new DocumentsCollection();

            foreach (var item in collection)
            {
                Console.WriteLine(item.Name);
            }
        }


    }
}
