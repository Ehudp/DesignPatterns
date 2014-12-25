using System;
using System.Collections.Generic;
using DesignPatterns.Utilities;
using DesignPatternsWpf.Model;

namespace DesignPatternsWpf.TreeFactory.Factories
{
    public class CreationalPatternsFactory : AbstractPatternsFactory
    {
        protected override PatternDetails CreatePatternDetails()
        {
            var creationalDetails = new PatternDetails
            {
                Name = "CreationalPatterns",
                Header = "Creational Patterns",
            };


            creationalDetails.Patterns.Add(new AbstractFactoryPatternsFactory().GetPatternDetails());
            creationalDetails.Patterns.Add(new BuilderPatternsFactory().GetPatternDetails());
            creationalDetails.Patterns.Add(new PrototypePatternsFactory().GetPatternDetails());
            creationalDetails.Patterns.Add(new SingletonPatternsFactory().GetPatternDetails());
            return creationalDetails;
        }
    }

    public class AbstractFactoryPatternsFactory : AbstractPatternsFactory
    {
        protected override PatternDetails CreatePatternDetails()
        {
            var abstractFactoryParent = new PatternDetails
            {
                Name = "AbstractFactory",
                Header = "Abstract Factory",
                Detailes = "Creates an instance of several families of classes - " +
                           "Provide an interface for creating families of related or dependent objects without specifying their concrete classes.",
                ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/AbstractFactoryUML.gif",
                UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/abstract-factory-design-pattern"),
                }
            };

            var abstractFactoryRealWorld = new PatternDetails
            {
                Name = "AbstractFactoryRealWorld",
                Header = "Abstract Factory Real World",
                Method = MethodService.AbstractFactoryRealWorld,
                Detailes =
                    "This real-world code demonstrates the creation of different animal worlds for a computer game using different factories."
                    +
                    "Although the animals created by the Continent factories are different, the interactions among the animals remain the same.",
                ImageUrl =
                    @"pack://application:,,,/DesignPatterns;component/Images/ClassDiagrams/AbstractFactoryRw.png",
                UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/abstract-factory-design-pattern#rea"),
                }
            };

            var abstractFactoryStructural = new PatternDetails
            {
                Name = "AbstractFactoryStructural",
                Header = "Abstract Factory Structural",
                Method = MethodService.AbstractFactoryStructural,
                Detailes =
                    "This structural code demonstrates the Abstract Factory pattern creating parallel hierarchies of objects."
                    +
                    " Object creation has been abstracted and there is no need for hard-coded class names in the client code.",
                ImageUrl =
                    @"pack://application:,,,/DesignPatterns;component/Images/ClassDiagrams/AbstractFactorySt.png",
                UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/abstract-factory-design-pattern#str"),
                }
            };


            abstractFactoryParent.Patterns.Add(abstractFactoryStructural);
            abstractFactoryParent.Patterns.Add(abstractFactoryRealWorld);

            return abstractFactoryParent;
        }
    }

    public class BuilderPatternsFactory : AbstractPatternsFactory
    {
        protected override PatternDetails CreatePatternDetails()
        {
            var builderParent = new PatternDetails
            {
                Name = "Builder",
                Header = "Builder",
                Detailes = "Separates object construction from its representation - " +
                           "Separate the construction of a complex object from its representation so that the same construction process can create different representations.",
                UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/builder-design-pattern"),
                }
            };

            var builderRealWorld = new PatternDetails
            {
                Name = "BuilderRealWorld",
                Header = "Builder Real World",
                Method = MethodService.BuilderRealWorld,
                Detailes =
                    "This real-world code demonstates the Builder pattern in which different vehicles are assembled in a step-by-step fashion. "
                    +
                    "The Shop uses VehicleBuilders to construct a variety of Vehicles in a series of sequential steps.",
                ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/BuilderUML.PNG",
                UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/builder-design-pattern#rea"),
                }
            };

            var builderStructural = new PatternDetails
            {
                Name = "BuilderStructural",
                Header = "Builder Structural",
                Method = MethodService.BuilderStructural,
                Detailes =
                    "This structural code demonstrates the Builder pattern in which complex objects are created in a step-by-step fashion."
                    +
                    " The construction process can create different object representations and provides a high level of control over the assembly of the objects.",
                ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/BuilderUML.PNG",
                UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/builder-design-pattern#str"),
                }
            };


            builderParent.Patterns.Add(builderStructural);
            builderParent.Patterns.Add(builderRealWorld);

            return builderParent;
        }
    }

    public class PrototypePatternsFactory : AbstractPatternsFactory
    {
        protected override PatternDetails CreatePatternDetails()
        {
            var prototypeParent = new PatternDetails
            {
                Name = "Prototype",
                Header = "Prototype",
                Detailes = "A fully initialized instance to be copied or cloned - " +
                           "Specify the kind of objects to create using a prototypical instance, and create new objects by copying this prototype.",
                UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/prototype-design-pattern"),
                }
            };

            var prototypeRealWorld = new PatternDetails
            {
                Name = "PrototypeRealWorld",
                Header = "Prototype Real World",
                Method = MethodService.PrototypeRealWorld,
                Detailes =
                    "This real-world code demonstrates the Prototype pattern in which new Color objects are created by copying pre-existing,"
                    + " user-defined Colors of the same type.",
                ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/PrototypeUML.PNG",
                UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/prototype-design-pattern#rea"),
                }
            };

            var prototypeStructural = new PatternDetails
            {
                Name = "PrototypeStructural",
                Header = "Prototype Structural",
                Method = MethodService.PrototypeStructural,
                Detailes =
                    "This structural code demonstrates the Prototype pattern in which new objects are created by copying pre-existing objects (prototypes) of the same class.",
                ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/PrototypeUML.PNG",
                UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/prototype-design-pattern#str"),
                }
            };

            prototypeParent.Patterns.Add(prototypeStructural);
            prototypeParent.Patterns.Add(prototypeRealWorld);

            return prototypeParent;
        }
    }

    public class SingletonPatternsFactory : AbstractPatternsFactory
    {
        protected override PatternDetails CreatePatternDetails()
        {
            var singletonParent = new PatternDetails
            {
                Name = "Singleton",
                Header = "Singleton",
                Detailes = "A class of which only a single instance can exist - " +
                           "Ensure a class has only one instance and provide a global point of access to it.",
                UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/singleton-design-pattern"),
                    new Uri("http://csharpindepth.com/articles/general/singleton.aspx")
                }
            };

            var singletonRealWorld = new PatternDetails
            {
                Name = "SingletonRealWorld",
                Header = "Singleton Real World",
                Method = MethodService.SingletonRealWorld,
                Detailes = "This real-world code demonstrates the Singleton pattern as a LoadBalancing object."
                           +
                           " Only a single instance (the singleton) of the class can be created because servers may dynamically "
                           +
                           "come on- or off-line and every request must go throught the one object that has knowledge"
                           + " about the state of the (web) farm.",
                ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/SingletonUML.PNG",
                UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/singleton-design-pattern#rea"),
                }
            };


            var singletonStructural = new PatternDetails
            {
                Name = "SingletonStructural",
                Header = "Singleton Structural",
                Method = MethodService.SingletonStructural,
                Detailes = "This structural code demonstrates the Singleton pattern which assures only"
                           + " a single instance (the singleton) of the class can be created.",
                ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/SingletonUML.PNG",
                UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/singleton-design-pattern#str"),
                }
            };

            singletonParent.Patterns.Add(singletonStructural);
            singletonParent.Patterns.Add(singletonRealWorld);

            return singletonParent;
        }
    }
}