using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DocumentA : BaseDocument, IDocument
    {
        public override void Create()
        {
            Console.WriteLine("DocumentA created");
            base.Create();
        }

        public override void Update()
        {
            Console.WriteLine("DocumentA updated");
            base.Create();
        }

        public override object Clone()
        {
            return new DocumentA() { Name = Name };
        }
    }
}
