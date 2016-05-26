using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{

    /// <summary>
    /// Avoid coupling the sender of a request to its receiver by giving more than one
    ///object a chance to handle the request.Chain the receiving objects and pass the
    ///request along the chain until an object handles it.
    /// </summary>
    class ChainOfResponsibility
    {

        void Caller()
        {
            Employee emp1 = new Bookkeeper();
            Employee emp2 = new Manager();

            emp1.Successor = emp2;


            BaseDocument doc = new DocumentA();

            emp1.ProcessDocument(doc);




        }
    }
}
