using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Prototype.RealWorld
{
    abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
}
