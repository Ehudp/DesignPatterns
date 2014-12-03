using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Creational_Patterns.Abstract_Factory.RealWorld;
using DesignPatterns.Creational_Patterns.Abstract_Factory.Structural;
using DesignPatterns.Creational_Patterns.Builder.Structural;

namespace DesignPatterns.Utilities
{
    public static class MethodService
    {
        #region Creational Patterns

        #region AbstractFactory
        
       
        //Structural 
        public static void AbstractFactoryStructural()
        {
            // Abstract factory #1
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

        }

        //Real-world
        public static void AbstractFactoryRealWorld()
        {
            // Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

        }
 
        #endregion

        #region Builder

        public static void BuilderStructural()
        {
            // Create director and builders
            Director director = new Director();

            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            // Construct two products
            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            // Wait for user
         
        }

        public static void BuilderRealWorld() 
        {

        }

        #endregion
        #endregion

    }
}
