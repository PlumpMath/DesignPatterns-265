using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class RenderingStrategy
    {
        public abstract void Render();

    }

    public class RenderingStrategyTabbed : RenderingStrategy
    {
        public override void Render()
        {
            Console.WriteLine("I am rendered in Tabbed style");
        }

    }

    public class RenderingStrategySinglePage : RenderingStrategy
    {
        public override void Render()
        {
            Console.WriteLine("I am rendered in SinglePage style");
        }

    }


}
