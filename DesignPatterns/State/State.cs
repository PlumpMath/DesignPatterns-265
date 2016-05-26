using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    class State
    {

        /// <summary>
        /// Allow an object to alter its behavior when its internal state changes. The object
        ///will appear to change its class.
        /// </summary>
        void Caller()
        {
            BaseDocument doc = null;

            doc = new DocumentA();
            doc.State = new DocumentEditableState() { Document = doc};
            doc.Confirm();

        }


    }
}
