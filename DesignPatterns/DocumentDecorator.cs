using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class DocumentDecorator : BaseDocument
    {
        public BaseDocument doc { get; set; }

        public override void Create()
        {
            doc.Create();
        }
        public override void Update()
        {
            doc.Update();
        }
    }

    public class DocumentDecoratorForLogging : DocumentDecorator
    {
        public override object Clone()
        {
            throw new NotImplementedException();
        }

        public override void Create()
        {
            Console.WriteLine("I am decorating this instance");
            doc.Create();
            Console.WriteLine("I am decorating this instance");
        }
        public override void Update()
        {
            Console.WriteLine("I am decorating this instance");
            doc.Update();
            Console.WriteLine("I am decorating this instance");
        }
    }

}
