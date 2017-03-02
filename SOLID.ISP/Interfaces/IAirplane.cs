using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.ISP
{
   public interface IAirplane
    {
        void Taxiing();
        void TakeOf();
        void Land();
    }
}
