using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace DesignPatterns.StructuralPatterns.Adapter.Structural
{
    class Adaptee
    {
        public void SpecificRequest()
        {
            Log.WriteLine("Called SpecificRequest()");
        }
    }
}
