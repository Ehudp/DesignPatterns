using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace DesignPatterns.StructuralPatterns.Adapter.Structural
{
    class Target
    {
        public virtual void Request()
        {
            Log.WriteLine("Called Target Request()");
        }
    }
}
