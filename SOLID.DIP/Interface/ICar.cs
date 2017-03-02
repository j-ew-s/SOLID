using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public interface IEngine
    {
        bool Start();
        bool TurnOf();
    }
}
