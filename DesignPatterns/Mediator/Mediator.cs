using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    class Mediator
    {
        /// <summary>
        /// Define an object that encapsula teshow a set o f objects interac t.Mediat or promotes
        ///loose coupling by keeping objects from referring to each other explicitly, and it
        ///lets you vary their interaction independently.
        /// </summary>
        void Caller()
        {
            DocumentsCoordinator mediator = new DocumentsCoordinator(new HashSet<BaseDocument>() { new DocumentA(), new DocumentB() });
            BaseDocument doc = new DocumentA();
            doc.SendCoordinationAction();



        }


    }
}
