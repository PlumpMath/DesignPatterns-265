using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DocumentsCoordinator
    {
        HashSet<BaseDocument> docs = new HashSet<BaseDocument>();
        public DocumentsCoordinator(HashSet<BaseDocument> docs)
        {
            this.docs = docs;
        }
        public void SendCoordinationAction(BaseDocument sender)
        {
            foreach (var item in docs)
            {
                item.ReceiveCoordinationAction(sender);
            }
        }
    }
}
