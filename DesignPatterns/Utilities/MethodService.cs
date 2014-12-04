using System;
using DesignPatterns.CreationalPatterns.AbstractFactory.RealWorld;
using DesignPatterns.CreationalPatterns.AbstractFactory.Structural;
using DesignPatterns.CreationalPatterns.Builder.RealWorld;
using DesignPatterns.CreationalPatterns.Builder.Structural;
using DesignPatterns.CreationalPatterns.Prototype.RealWorld;
using DesignPatterns.CreationalPatterns.Prototype.Structural;
using DesignPatterns.CreationalPatterns.Singleton.RealWorld;
using DesignPatterns.CreationalPatterns.Singleton.Structural;
using Logger;

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
            Log.WriteLine("{0} has Created", factory1.GetType().Name);

          
            var client1 = new Client(factory1);
            Log.WriteLine("{0} has Created", client1.GetType().Name);
            Log.WriteLine("Client Create AbstractProductA and AbstractProductB");
            Log.WriteLine("Client Run");
            client1.Run();

            // Abstract factory #2
            AbstractFactory factory2 = new ConcreteFactory2();
            
            Log.AddSeparator(5);
            Log.WriteLine("{0} has Created", factory2.GetType().Name);
        
            var client2 = new Client(factory2);
            client2.Run();
        }

        //Real-world
        public static void AbstractFactoryRealWorld()
        {
            // Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            var world = new AnimalWorld(africa);
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
            var director = new Director();

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
            VehicleBuilder builder;

            // Create shop with vehicle builders
            var shop = new Shop();

            // Construct and display vehicles
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
        }

        #endregion

        #region Prototype

        public static void PrototypeRealWorld()
        {
            var colormanager = new ColorManager();

            // Initialize with standard colors
            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors
            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            // User clones selected colors
            var color1 = colormanager["red"].Clone() as Color;
            var color2 = colormanager["peace"].Clone() as Color;
            var color3 = colormanager["flame"].Clone() as Color;
        }

        public static void PrototypeStructural()
        {
            // Create two instances and clone each

            var p1 = new ConcretePrototype1("I");
            var c1 = (ConcretePrototype1)p1.Clone();
            Log.WriteLine("Cloned: {0}", c1.Id);

            var p2 = new ConcretePrototype2("II");
            var c2 = (ConcretePrototype2)p2.Clone();
            Log.WriteLine("Cloned: {0}", c2.Id);
        }

        #endregion

        #region Singleton

        public static void SingletonRealWorld()
        {
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            // Same instance?
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Log.WriteLine("Same instance\n");
            }

            // Load balance 15 server requests
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Log.WriteLine("Dispatch Request to: " + server);
            }
        }

        public static void SingletonStructural()
        {
            // Constructor is protected -- cannot use new
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            // Test for same instance
            if (s1 == s2)
            {
                Log.WriteLine("Objects are the same instance");
            }
        }

        #endregion

        #endregion
    }
}