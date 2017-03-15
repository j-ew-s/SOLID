using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    public class Boat : IBoat
    {
        public  void Dock()
        {
            throw new NotImplementedException();
        }

        public  void Row()
        {
            throw new NotImplementedException();
        }
    }
}
