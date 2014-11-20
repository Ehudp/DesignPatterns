using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Abstract_Factory.RealWorld
{
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison
            Logger.Log.WriteLine(GetType().Name +
              " eats " + h.GetType().Name);            
        }
    }
}
