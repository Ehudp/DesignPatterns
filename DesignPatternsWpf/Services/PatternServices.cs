using DesignPatterns.Utilities;
using DesignPatternsWpf.Model;
using Infrastructures.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsWpf.Services
{
    public static class PatternServices
    {

        public static PatternDetails GetCreationalPatternsTree()
        {

            PatternDetails creationaParent = new PatternDetails
            {
                Name = "CreationalPatterns",
                Header = "Creational Patterns",
            };


            creationaParent.Patterns.Add(AbstractFactoryTree());
            creationaParent.Patterns.Add(BuilderTree());
            creationaParent.Patterns.Add(PrototypeTree());
            creationaParent.Patterns.Add(SingletonTree());
            return creationaParent;

        }

        private static PatternDetails AbstractFactoryTree()
        {

            PatternDetails abstractFactoryParent = new PatternDetails
            {
                Name = "AbstractFactory",
                Header = "Abstract Factory",
                Detailes = "Creates an instance of several families of classes - " +
                           "Provide an interface for creating families of related or dependent objects without specifying their concrete classes.",
                Url = "http://www.dofactory.com/net/abstract-factory-design-pattern",
                ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/AbstractFactoryUML.gif"
            };

            PatternDetails abstractFactoryRealWorld = new PatternDetails
            {
                Name = "AbstractFactoryRealWorld",
                Header = "Abstract Factory Real World",
                IsGofPattern = true,
                Method = MethodService.AbstractFactoryRealWorld,
                Detailes = "This real-world code demonstrates the creation of different animal worlds for a computer game using different factories."
               + "Although the animals created by the Continent factories are different, the interactions among the animals remain the same.",
                Url = "http://www.dofactory.com/net/abstract-factory-design-pattern#rea",
                ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/ClassDiagrams/AbstractFactoryRw.png"
            };

            PatternDetails abstractFactoryStructural = new PatternDetails
            {
                Name = "AbstractFactoryStructural",
                Header = "Abstract Factory Structural",
                IsGofPattern = true,
                Method = MethodService.AbstractFactoryStructural,
                Detailes = "This structural code demonstrates the Abstract Factory pattern creating parallel hierarchies of objects."
                + " Object creation has been abstracted and there is no need for hard-coded class names in the client code.",
                Url = "http://www.dofactory.com/net/abstract-factory-design-pattern#str",
                ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/ClassDiagrams/AbstractFactorySt.png"

            };


            abstractFactoryParent.Patterns.Add(abstractFactoryStructural);
            abstractFactoryParent.Patterns.Add(abstractFactoryRealWorld);

            return abstractFactoryParent;
        }

        private static PatternDetails BuilderTree()
        {

            PatternDetails builderParent = new PatternDetails
            {
                Name = "Builder",
                Header = "Builder",
                Detailes = "Separates object construction from its representation - " +
                "Separate the construction of a complex object from its representation so that the same construction process can create different representations."
            };

            PatternDetails builderRealWorld = new PatternDetails
            {
                Name = "BuilderRealWorld",
                Header = "Builder Real World",
                IsGofPattern = true,
                Method = MethodService.BuilderRealWorld,
                Detailes = "This real-world code demonstates the Builder pattern in which different vehicles are assembled in a step-by-step fashion. "
                + "The Shop uses VehicleBuilders to construct a variety of Vehicles in a series of sequential steps.",
                Url = "http://www.dofactory.com/net/builder-design-pattern#rea",
                ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/BuilderUML.PNG"
            };

            PatternDetails builderStructural = new PatternDetails
            {
                Name = "BuilderStructural",
                Header = "Builder Structural",
                IsGofPattern = true,
                Method = MethodService.BuilderStructural,
                Detailes = "This structural code demonstrates the Builder pattern in which complex objects are created in a step-by-step fashion."
                + " The construction process can create different object representations and provides a high level of control over the assembly of the objects.",
                Url = "http://www.dofactory.com/net/builder-design-pattern#str",
                ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/BuilderUML.PNG"

            };


            builderParent.Patterns.Add(builderStructural);
            builderParent.Patterns.Add(builderRealWorld);

            return builderParent;
        }

        private static PatternDetails PrototypeTree()
        {

            PatternDetails prototypeParent = new PatternDetails
            {
                Name = "Prototype",
                Header = "Prototype",
                Detailes = "A fully initialized instance to be copied or cloned - " +
                "Specify the kind of objects to create using a prototypical instance, and create new objects by copying this prototype."
            };

            PatternDetails prototypeRealWorld = new PatternDetails
            {
                Name = "PrototypeRealWorld",
                Header = "Prototype Real World",
                IsGofPattern = true,
                Method = MethodService.PrototypeRealWorld,
                Detailes = "This real-world code demonstrates the Prototype pattern in which new Color objects are created by copying pre-existing,"
                + " user-defined Colors of the same type.",
                Url = "http://www.dofactory.com/net/prototype-design-pattern#rea",
                ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/PrototypeUML.PNG"
            };

            PatternDetails prototypeStructural = new PatternDetails
            {
                Name = "PrototypeStructural",
                Header = "Prototype Structural",
                IsGofPattern = true,
                Method = MethodService.PrototypeStructural,
                Detailes = "This structural code demonstrates the Prototype pattern in which new objects are created by copying pre-existing objects (prototypes) of the same class.",
                Url = "http://www.dofactory.com/net/prototype-design-pattern#str",
                ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/PrototypeUML.PNG"

            };

            prototypeParent.Patterns.Add(prototypeStructural);
            prototypeParent.Patterns.Add(prototypeRealWorld);

            return prototypeParent;
        }

        private static PatternDetails SingletonTree()
        {

            PatternDetails singletonParent = new PatternDetails
            {
                Name = "Singleton",
                Header = "Singleton",
                Detailes = "A class of which only a single instance can exist - " +
                "Ensure a class has only one instance and provide a global point of access to it."
            };

            PatternDetails singletonRealWorld = new PatternDetails
            {
                Name = "SingletonRealWorld",
                Header = "Singleton Real World",
                IsGofPattern = true,
                Method = MethodService.SingletonRealWorld,
                Detailes = "This real-world code demonstrates the Singleton pattern as a LoadBalancing object."
                + " Only a single instance (the singleton) of the class can be created because servers may dynamically "
                + "come on- or off-line and every request must go throught the one object that has knowledge"
                + " about the state of the (web) farm.",
                Url = "http://www.dofactory.com/net/singleton-design-pattern#rea",
                ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/SingletonUML.PNG"
            };

            PatternDetails singletonStructural = new PatternDetails
            {
                Name = "SingletonStructural",
                Header = "Singleton Structural",
                IsGofPattern = true,
                Method = MethodService.SingletonStructural,
                Detailes = "This structural code demonstrates the Singleton pattern which assures only"
                + " a single instance (the singleton) of the class can be created.",
                Url = "http://www.dofactory.com/net/singleton-design-pattern#str",
                ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/SingletonUML.PNG"

            };

            singletonParent.Patterns.Add(singletonStructural);
            singletonParent.Patterns.Add(singletonRealWorld);

            return singletonParent;
        }
    }
}
