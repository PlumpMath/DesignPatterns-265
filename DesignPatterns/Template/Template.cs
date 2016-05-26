using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{

    /// <summary>
    /// Define the skeleton of an algorithm in an operation, deferring some steps to
    ///subclass es.Template Method lets subclass es redefine certain ste ps of an algorithm
    ///without changing the algorithm's structure.
    /// </summary>
    class Template
    {

        void Caller()
        {
            IDocument doc = null;

            doc = new DocumentA();
            doc.Create();


            doc = new DocumentB();
            doc.Create();


            BaseDocument document = new DocumentB();
            document.Save();

        }


    }
}
