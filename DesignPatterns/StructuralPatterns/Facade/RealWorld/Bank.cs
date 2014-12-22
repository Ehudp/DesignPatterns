using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace DesignPatterns.StructuralPatterns.Facade.RealWorld
{
    class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Log.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }
}
