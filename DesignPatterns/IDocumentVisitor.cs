using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class IDocumentVisitor
    {
       public abstract void Visit(BaseDocument document);

    }

    public class DocumentHistoryMakerVisitor : IDocumentVisitor
    {
        public override void Visit(BaseDocument document)
        {
            Console.WriteLine("History created");
        }


    }



}
