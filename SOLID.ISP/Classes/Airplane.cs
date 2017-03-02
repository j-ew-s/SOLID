using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    public class Airplane : IAirplane
    {
        public static void Land()
        {
            throw new NotImplementedException();
        }

        public static void TakeOf()
        {
            throw new NotImplementedException();
        }

        public static void Taxiing()
        {
            throw new NotImplementedException();
        }
    }
}
