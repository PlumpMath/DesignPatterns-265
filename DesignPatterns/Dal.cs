using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    public interface IDal
    {
        void Create(BaseDocument doc);
        void Update(BaseDocument doc);
    }


    public abstract class Dal : IDal
    {
        public abstract void Create(BaseDocument doc);
        public abstract void Update(BaseDocument doc);
    }


    public class DalThroughEF : Dal
    {
        public override void Create(BaseDocument doc)
        {

        }
        public override void Update(BaseDocument doc)
        {
        }
    }





    public class DalViaOdata
    {
        public void Post(BaseDocument doc)
        {

        }
        public void Put(BaseDocument doc)
        {
        }
    }




}



