

using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using DesignPatterns.BehavioralPatterns.ChainOfResp.RealWorld;
using DesignPatterns.BehavioralPatterns.ChainOfResp.Structural;
using DesignPatterns.BehavioralPatterns.Command.RealWorld;
using DesignPatterns.BehavioralPatterns.Command.Structural;
using DesignPatterns.BehavioralPatterns.Interpreter.RealWorld;
using DesignPatterns.BehavioralPatterns.Interpreter.Structural;
using DesignPatterns.BehavioralPatterns.Iterator.RealWorld;
using DesignPatterns.BehavioralPatterns.Iterator.Structural;
using DesignPatterns.BehavioralPatterns.Mediator.RealWorld;
using DesignPatterns.BehavioralPatterns.Mediator.Structural;
using DesignPatterns.BehavioralPatterns.Memento.RealWorld;
using DesignPatterns.BehavioralPatterns.Memento.Structural;
using DesignPatterns.BehavioralPatterns.Observer.RealWorld;
using DesignPatterns.BehavioralPatterns.Observer.Structural;
using DesignPatterns.BehavioralPatterns.State.RealWorld;
using DesignPatterns.BehavioralPatterns.State.Structural;
using DesignPatterns.BehavioralPatterns.Strategy.RealWorld;
using DesignPatterns.BehavioralPatterns.Strategy.Structural;
using DesignPatterns.BehavioralPatterns.TemplateMethod.RealWorld;
using DesignPatterns.BehavioralPatterns.TemplateMethod.Structural;
using DesignPatterns.BehavioralPatterns.Visitor.RealWorld;
using DesignPatterns.BehavioralPatterns.Visitor.Structural;
using DesignPatterns.CreationalPatterns.AbstractFactory.RealWorld;
using DesignPatterns.CreationalPatterns.AbstractFactory.Structural;
using DesignPatterns.CreationalPatterns.Builder.RealWorld;
using DesignPatterns.CreationalPatterns.Builder.Structural;
using DesignPatterns.CreationalPatterns.Prototype.RealWorld;
using DesignPatterns.CreationalPatterns.Prototype.Structural;
using DesignPatterns.CreationalPatterns.Singleton.RealWorld;
using DesignPatterns.CreationalPatterns.Singleton.Structural;
using DesignPatterns.StructuralPatterns.Adapter.RealWorld;
using DesignPatterns.StructuralPatterns.Adapter.Structural;
using DesignPatterns.StructuralPatterns.Bridge.RealWorld;
using DesignPatterns.StructuralPatterns.Bridge.Structural;
using DesignPatterns.StructuralPatterns.Composite.RealWorld;
using DesignPatterns.StructuralPatterns.Composite.Structural;
using DesignPatterns.StructuralPatterns.Decorator.RealWorld;
using DesignPatterns.StructuralPatterns.Decorator.Structural;
using DesignPatterns.StructuralPatterns.Facade.RealWorld;
using DesignPatterns.StructuralPatterns.Facade.Structural;
using DesignPatterns.StructuralPatterns.Flyweight.RealWorld;
using DesignPatterns.StructuralPatterns.Flyweight.Structural;
using DesignPatterns.StructuralPatterns.Proxy.RealWorld;
using DesignPatterns.StructuralPatterns.Proxy.Structural;
using Logger;
using Command = DesignPatterns.BehavioralPatterns.Command.Structural.Command;
using Context = System.Runtime.Remoting.Contexts.Context;
using Director = DesignPatterns.CreationalPatterns.Builder.Structural.Director;
using Iterator = DesignPatterns.BehavioralPatterns.Iterator.Structural.StructIterator;
using President = DesignPatterns.BehavioralPatterns.ChainOfResp.RealWorld.President;
using SortedList = System.Collections.SortedList;


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
            Log.WriteLine("{0} has Construct {1}", director.GetType().Name, b1.GetType().Name);
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

        #region Structural Patterns

        public static void AdapterStructural()
        {
            Target target = new Adapter();
            target.Request();
        }

        public static void AdapterRealWorld()
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
 
        }

        public static void BridgeStructural()
        {
            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            // Change implemention and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();
        }

        public static void BridgeRealWorld()
        {
            Customers customers = new Customers("Chicago");

            // Set ConcreteImplementor
            customers.Data = new CustomersData();

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();
        }

        public static void CompositeStructural()
        {
            // Create a tree structure
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Add and remove a leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            // Recursively display tree
            root.Display(1);
        }

        public static void CompositeRealWorld()
        {
            CompositeElement root =new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            // Create a branch
            CompositeElement comp =new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            // Add and remove a PrimitiveElement
            PrimitiveElement pe =new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            // Recursively display nodes
            root.Display(1);
        }

        public static void DecoratorStructural()
        {
            // Create ConcreteComponent and two Decorators
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();
 
        }

        public static void DecoratorRealWorld()
        {
            // Create book
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, then borrow and display
            Log.WriteLine("\nMaking video borrowable:");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();
        }

        public static void FacadeStructural()
        {
            // Create ConcreteComponent and two Decorators
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();
 

        }

        public static void FacadeRealWorld()
        {
            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Log.WriteLine("\n" + customer.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));
 
        }

        public static void FlyweightStructural()
        {
            // Arbitrary extrinsic state
            int extrinsicstate = 22;

            FlyweightFactory factory = new FlyweightFactory();

            // Work with different flyweight instances
            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new
              UnsharedConcreteFlyweight();

            fu.Operation(--extrinsicstate);

        }

        public static void FlyweightRealWorld()
        {
          
            // Build a document with text
            string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            // extrinsic state
            int pointSize = 10;

            // For each character use a flyweight object
            foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }
        }

        public static void ProxyStructural()
        {
            // Create proxy and request a service
            Proxy proxy = new Proxy();
            proxy.Request();

        }

        public static void ProxyRealWorld()
        {

            MathProxy proxy = new MathProxy();

            // Do the math
            Log.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Log.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Log.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Log.WriteLine("4 / 2 = " + proxy.Div(4, 2));
        }
   
        #endregion

        #region Behavioral Patterns

        public static void ChainOfRespStructural()
        {
            // Setup Chain of Responsibility
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            // Generate and process request
            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }

        }

        public static void ChainOfRespRealWorld()
        {

            // Setup Chain of Responsibility
            Approver larry = new Boss();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            // Generate and process purchase requests
            Purchase p = new Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);
        }

        public static void CommandStructural()
        {
            // Create receiver, command, and invoker
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            // Set and execute command
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

        }

        public static void CommandRealWorld()
        {

            // Create user and let her compute
            User user = new User();

            // User presses calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            // Redo 3 commands
            user.Redo(3);
        }

        public static void InterpreterStructural()
        {
            StructContext context = new StructContext();

            // Usually a tree 
            ArrayList list = new ArrayList();

            // Populate 'abstract syntax tree' 
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            // Interpret
            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }
 

        }

        public static void InterpreterRealWorld()
        {

            string roman = "MCMXXVIII";
            RealContext context = new RealContext(roman);

            // Build the 'parse tree'
            List<RealExpression> tree = new List<RealExpression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // Interpret
            foreach (RealExpression exp in tree)
            {
                exp.Interpret(context);
            }

            Log.WriteLine("{0} = {1}",roman, context.Output);
        }

        public static void IteratorStructural()
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            // Create Iterator and provide aggregate
            ConcreteIterator i = new ConcreteIterator(a);

            Log.WriteLine("Iterating over collection:");

            object item = i.First();
            while (item != null)
            {
                Log.WriteLine(item.ToString());
                item = i.Next();
            }

        }

        public static void IteratorRealWorld()
        {

            // Build a collection
            Collection collection = new Collection();
            collection[0] = new Item("Item 0");
            collection[1] = new Item("Item 1");
            collection[2] = new Item("Item 2");
            collection[3] = new Item("Item 3");
            collection[4] = new Item("Item 4");
            collection[5] = new Item("Item 5");
            collection[6] = new Item("Item 6");
            collection[7] = new Item("Item 7");
            collection[8] = new Item("Item 8");

            // Create iterator
            RealIterator iterator = new RealIterator(collection);

            // Skip every other item
            iterator.Step = 2;

            Log.WriteLine("Iterating over collection:");

            for (Item item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Log.WriteLine(item.Name);
            }
        }

        public static void MediatorStructural()
        {
            ConcreteMediator m = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;

            c1.Send("How are you?");
            c2.Send("Fine, thanks");

        }

        public static void MediatorRealWorld()
        {

            // Create chatroom
            Chatroom chatroom = new Chatroom();

            // Create participants and register them
            Participant George = new Beatle("George");
            Participant Paul = new Beatle("Paul");
            Participant Ringo = new Beatle("Ringo");
            Participant John = new Beatle("John");
            Participant Yoko = new NonBeatle("Yoko");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            // Chatting participants
            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");
        }

        public static void MementoStructural()
        {
            Originator o = new Originator();
            o.State = "On";

            // Store internal state
            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            // Continue changing originator
            o.State = "Off";

            // Restore saved state
            o.SetMemento(c.Memento);

        }

        public static void MementoRealWorld()
        {

            SalesProspect s = new SalesProspect();
            s.Name = "Noel van Halen";
            s.Phone = "(412) 256-0990";
            s.Budget = 25000.0;

            // Store internal state
            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();

            // Continue changing originator
            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;

            // Restore saved state
            s.RestoreMemento(m.Memento);
        }

        public static void ObserverStructural()
        {
            // Configure Observer pattern
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();

        }

        public static void ObserverRealWorld()
        {

            // Create IBM stock and attach investors
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
        }

        public static void StateStructural()
        {
            // Setup context in a state
            StateContext c = new StateContext(new ConcreteStateA());

            // Issue requests, which toggles state
            c.Request();
            c.Request();
            c.Request();
            c.Request();

        }

        public static void StateRealWorld()
        {

            // Open a new account
            Account account = new Account("Jim Johnson");

            // Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
        }

        public static void StrategyStructural()
        {
            StrategyContext context;

            // Three contexts following different strategies
            context = new StrategyContext(new ConcreteStrategyA());
            context.ContextInterface();

            context = new StrategyContext(new ConcreteStrategyB());
            context.ContextInterface();

            context = new StrategyContext(new ConcreteStrategyC());
            context.ContextInterface();

        }

        public static void StrategyRealWorld()
        {

            // Two contexts following different strategies
            StrategySortedList studentRecords = new StrategySortedList();

            studentRecords.Add("Samuel");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
 
        }

        public static void TemplateMethodStructural()
        {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();

            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();
 

        }

        public static void TemplateMethodRealWorld()
        {

            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();

            DataAccessObject daoProducts = new Products();
            daoProducts.Run();
        }

        public static void VisitorStructural()
        {
            // Setup structure
            ObjectStructure o = new ObjectStructure();
            o.Attach(new ConcreteElementA());
            o.Attach(new ConcreteElementB());

            // Create visitor objects
            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            ConcreteVisitor2 v2 = new ConcreteVisitor2();

            // Structure accepting visitors
            o.Accept(v1);
            o.Accept(v2);
        }

        public static void VisitorRealWorld()
        {

            // Setup employee collection
            Employees e = new Employees();
            e.Attach(new VisitorClerk());
            e.Attach(new VisitorDirector());
            e.Attach(new VisitorPresident());

            // Employees are 'visited'
            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());
 
        }
        
        #endregion
    }
}