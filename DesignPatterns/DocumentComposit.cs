using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DocumentComposite : BaseDocument 
    {
        public List<BaseDocument> docs = new List<BaseDocument>();

        public override void Create()
        {
            foreach (var item in docs)
            {
                item.Create();
            }
        }

        public override void Update()
        {
            foreach (var item in docs)
            {
                item.Update();
            }
        }

        public override void AddDocument(BaseDocument doc)
        {
            docs.Add(doc);
        }
        public override void RemoveDocument(BaseDocument doc)
        {
            docs.Remove(doc);
        }

        public override object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
