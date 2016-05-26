using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DocumentB : BaseDocument, IDocument
    {
        public override void Create()
        {
            Console.WriteLine("DocumentB created");
            dal.Create(this);
        }

        public override void Update()
        {
            Console.WriteLine("DocumentB updated");
            dal.Create(this);
        }

        public override object Clone()
        {
            return new DocumentB() { Name = Name };
        }
    }
}
