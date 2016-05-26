using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    class Memento
    {

        /// <summary>
        /// Without violating encapsulation, capture and externalize an object's internal state
        ///so that the object can be restored to this state later.
        /// </summary>
        void Caller()
        {
            BaseDocument doc = null;

            doc = new DocumentA() { Name = "my Name" };

            MementoMamanger manager = new MementoMamanger() { Memento = doc.CreateMemento() };

            doc.StoreFromMemento(manager.Memento);





        }
    }
}
