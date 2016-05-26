using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{


    /// <summary>
    /// Represent an operation to be performed on the elements of an object struc ture.Visitor
    ///lets you define a new operation without changing the classes of the elements
    ///on which it operates.
    /// </summary>
    class Visitor
    {

        void Caller()
        {
            DocumentsCollection collection = new DocumentsCollection();
            collection.Add(new DocumentA());
            collection.Add(new DocumentB());

            collection.AcceptVisitor(new DocumentHistoryMakerVisitor());


        }
    }
}
