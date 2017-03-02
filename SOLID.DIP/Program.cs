using DryIoc;
using SOLID.DIP.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var c = new Container();
            c.Register<IEngine, Car>();
            c.Register<IEngine, Motorcycle>();

            // somewhere else
            IEngine client = c.Resolve<IEngine>();

            client.Start();
        }
    }
}
