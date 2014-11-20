using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace DesignPatterns.Creational_Patterns.Abstract_Factory.Structural
{
    class ProductB2:AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Log.WriteLine(GetType().Name +
              " interacts with " + a.GetType().Name);          
        }
    }
}
