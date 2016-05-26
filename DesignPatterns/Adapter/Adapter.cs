using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class Adapter
    {

        public class MyDalViaOdata : Dal
        {
            public DalViaOdata odata { get; set; }

            public override void Create(BaseDocument doc)
            {
                odata.Post(doc);
            }

            public override void Update(BaseDocument doc)
            {
                odata.Put(doc);
            }
        }

        public class MyDalViaOdata1 : DalViaOdata, IDal
        { 

            public void Create(BaseDocument doc)
            {
                base.Post(doc);
            }

            public void Update(BaseDocument doc)
            {
                base.Put(doc);
            }
        }


    }
}
