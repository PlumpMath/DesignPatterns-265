using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Employee
    {
        public Employee Successor { get; set; }

        public abstract void ConfirmDocument(BaseDocument doc);

        public abstract void ProcessDocument(BaseDocument doc);

    }


    public class Bookkeeper : Employee
    {
        public override void ConfirmDocument(BaseDocument doc)
        {
            Console.WriteLine("BookKeeper confirmed the doc");
        }

        public override void ProcessDocument(BaseDocument doc)
        {
            if (Successor != null)
                Successor.ProcessDocument(doc);
        }
    }


    public class Manager : Employee
    {
        public override void ConfirmDocument(BaseDocument doc)
        {
            Console.WriteLine("Manager confirmed the doc");
        }

        public override void ProcessDocument(BaseDocument doc)
        {
            Console.WriteLine("Manager confirmed the doc");
        }
    }


}
