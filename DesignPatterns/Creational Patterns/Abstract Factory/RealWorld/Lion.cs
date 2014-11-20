using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace DesignPatterns.Creational_Patterns.Abstract_Factory.RealWorld
{
    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest
            Log.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);          
        }
    }
}
