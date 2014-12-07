﻿using System;
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

            Log.AddSeparator(5);
            // Abstract factory #2
            AbstractFactory factory2 = new ConcreteFactory2();                       
            Log.WriteLine("{0} has Created", factory2.GetType().Name);        
            var client2 = new Client(factory2);
            Log.WriteLine("{0} has Created", client2.GetType().Name);
            Log.WriteLine("Client Create AbstractProductA and AbstractProductB");
            Log.WriteLine("Client Run");
            client2.Run();
        }

        //Real-world
        public static void AbstractFactoryRealWorld()
        {
            // Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            Log.WriteLine("{0} has Created", africa.GetType().Name);
            var world = new AnimalWorld(africa);
            Log.WriteLine("{0} has Created", world.GetType().Name);
            Log.WriteLine("Animal World Create Herbivore and Carnivore");
            Log.WriteLine("Animal World Run Food Chain");
            world.RunFoodChain();

            Log.AddSeparator(5);
            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            Log.WriteLine("{0} has Created", america.GetType().Name);
            world = new AnimalWorld(america);
            Log.WriteLine("{0} has Created", world.GetType().Name);
            Log.WriteLine("Animal World Create Herbivore and Carnivore");
            Log.WriteLine("Animal World Run Food Chain");
            world.RunFoodChain();
        }

        #endregion

        #region Builder

        public static void BuilderStructural()
        {
            // Create director and builders
            var director = new Director();
            Log.WriteLine("{0} has Created", director.GetType().Name);
            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();
            Log.WriteLine("{0} has Created", b1.GetType().Name);
            Log.WriteLine("{0} has Created", b2.GetType().Name);
          
            Log.AddSeparator(5);
            // Construct two products
            director.Construct(b1);
            Log.WriteLine("{0} has Construct {1}", director.GetType().Name,b1.GetType().Name);
            Product p1 = b1.GetResult();
            Log.WriteLine("Get Resuult");
            p1.Show();
            Log.AddSeparator(5);
            director.Construct(b2);
            Log.WriteLine("{0} has Construct {1}", director.GetType().Name, b2.GetType().Name);
            Product p2 = b2.GetResult();
            Log.WriteLine("Get Resuult");
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
            Log.WriteLine("\n{0} has Created", builder.GetType().Name);
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            Log.WriteLine("\n{0} has Created", builder.GetType().Name);
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            Log.WriteLine("\n{0} has Created", builder.GetType().Name);
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