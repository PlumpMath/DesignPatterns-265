using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    class Observer
    {
        /// <summary>
        /// Define a one-to-many dependency between objects so that when one object
        ///changes state, all its dependents are notified and updated automatically.
        /// </summary>
        void Caller()
        {
            BaseDocument doc = null;

            doc = new DocumentA() {  Owners = new List<Employee>() { new Manager(), new Bookkeeper()} };
            doc.Create();



        }

    }
}
