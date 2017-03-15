using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    public  class Airplane : IAirplane
    {
        public  void Land()
        {
            throw new NotImplementedException();
        }

        public  void TakeOf()
        {
            throw new NotImplementedException();
        }

        public  void Taxiing()
        {
            throw new NotImplementedException();
        }
    }
}
