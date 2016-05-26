using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DocumentMemento
    {

        public int Id { get; set; }
        public string Name { get; set; }


    }


    public class MementoMamanger
    {
        public DocumentMemento Memento { get; set; }
    }



}
