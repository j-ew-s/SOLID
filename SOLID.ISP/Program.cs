using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Airplane.Taxiing();
            Airplane.TakeOf();
            Airplane.Land();

            Car.StarEngine();
            Car.Park();

            Boat.Dock();
            Boat.Row();
        }
    }
}
