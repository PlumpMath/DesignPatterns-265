using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class DocumentState
    {
        public BaseDocument Document { get; set; }

        public abstract void Confirm();
    }


    public class DocumentEditableState : DocumentState
    {
        public override void Confirm()
        {
            Document.State = new DocumentSignedState() { Document = base.Document};
        }
    }


    public class DocumentSignedState : DocumentState
    {
        public override void Confirm()
        {
            Document.State = new DocumentSentState() { Document = base.Document };
        }
    }


    public class DocumentSentState : DocumentState
    {
        public override void Confirm()
        {
            throw new Exception("you cant change the state");
        }
    }
}
