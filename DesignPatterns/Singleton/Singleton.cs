using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {

        static Singleton instance;

        object locker = new object();

        Lazy<Singleton> lazyInstance = new Lazy<Singleton>(() => { return new Singleton(); }, true);

        private Singleton()
        {

        }


        public Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }


        public Singleton GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                    lock (locker)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }

                return instance;
            }
        }



        public Singleton GetInstanceLazily
        {
            get
            {
                return lazyInstance.Value;
            }
        }

    }
}
