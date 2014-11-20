using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Abstract_Factory.Structural
{
   abstract class AbstractFactory
    {
       public abstract AbstractProductA CreateProductA();
       public abstract AbstractProductB CreateProductB();
    }
}
