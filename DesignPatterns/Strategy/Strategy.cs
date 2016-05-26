using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{

    /// <summary>
    /// Define a family oafl gorit h ms, encapsulate each one, and make them interchangeable.
    ///Strategy lets the algorithm vary independently from clients that use it.
    /// </summary>
    public class Strategy
    {
        void Caller()
        {
            BaseDocument doc = null;

            doc = new DocumentA() { RenderingStrategy = new RenderingStrategyTabbed() };
            doc.Render();


            doc = new DocumentB() { RenderingStrategy = new RenderingStrategySinglePage() };
            doc.Render();


        }
    }
}
