using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    public   class Car : ICar
    {
        public  void Park()
        {
            throw new NotImplementedException();
        }

        public  void StarEngine()
        {
            throw new NotImplementedException();
        }
    }
}
