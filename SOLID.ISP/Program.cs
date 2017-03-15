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
            var airPlane = new Airplane();
            airPlane.Taxiing();
            airPlane.TakeOf();
            airPlane.Land();

            var car = new Car();
            car.StarEngine();
            car.Park();

            var boat = new Boat();
            boat.Dock();
            boat.Row();
        }
    }
}
