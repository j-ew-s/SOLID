using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    public  static class Car : ICar
    {
        public static void Park()
        {
            throw new NotImplementedException();
        }

        public static void StarEngine()
        {
            throw new NotImplementedException();
        }
    }
}
