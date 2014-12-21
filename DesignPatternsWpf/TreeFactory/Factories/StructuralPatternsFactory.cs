using DesignPatterns.Utilities;
using DesignPatternsWpf.Model;
using DesignPatternsWpf.Services;
using System;
using System.Collections.Generic;

namespace DesignPatternsWpf.TreeFactory.Factories
{
    public class StructuralPatternsFactory : AbstractPatternsFactory
    {

        protected override PatternDetails CreatePatternDetails()
        {
            var structuralDetails = new PatternDetails
            {
                Name = "Structural",
                Header = "Structural Patterns",
            };

            structuralDetails.Patterns.Add(this.GetPatternsFromFactory<AdapterPatternsFactory>());
            structuralDetails.Patterns.Add(this.GetPatternsFromFactory<BridgePatternsFactory>());
            structuralDetails.Patterns.Add(this.GetPatternsFromFactory<CompositePatternsFactory>());
            structuralDetails.Patterns.Add(this.GetPatternsFromFactory<DecoratorePatternsFactory>());

            return structuralDetails;
        }

        public class AdapterPatternsFactory : AbstractPatternsFactory
        {
            protected override PatternDetails CreatePatternDetails()
            {
                var adapterParent = new PatternDetails
                {
                    Name = "Adapter",
                    Header = "Adapter",
                    Detailes = "Match interfaces of different classes - " +
                               "Convert the interface of a class into another interface clients expect. Adapter lets "
                               + "classes work together that couldn't otherwise because of incompatible interfaces.",
                    ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/AdapterUML.gif",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/adapter-design-pattern"),
                }
                };

                var adapterStructural = new PatternDetails
                {
                    Name = "AdapterStructural",
                    Header = "Adapter Structural",
                    IsGofPattern = true,
                    Method = MethodService.AdapterStructural,
                    Detailes =
                        "This structural code demonstrates the Adapter pattern which maps the interface of one class " +
                        "onto another so that they can work together. These incompatible classes may come from different libraries or frameworks.",
                    ImageUrl =
                        @"pack://application:,,,/DesignPatterns;component/Images/ClassDiagrams/AdapterUML.png",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/adapter-design-pattern#str"),
                }
                };


                var adapterRealWorld = new PatternDetails
                {
                    Name = "AdapterRealWorld",
                    Header = "Adapter Real World",
                    IsGofPattern = true,
                    Method = MethodService.AdapterRealWorld,
                    Detailes = "This real-world code demonstrates the use of a legacy chemical databank." +
                    " Chemical compound objects access the databank through an Adapter interface.",
                    ImageUrl =
                        @"pack://application:,,,/DesignPatterns;component/Images/ClassDiagrams/AdapterUML.png",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/adapter-design-pattern#rea"),
                }
                };

                adapterParent.Patterns.Add(adapterStructural);
                adapterParent.Patterns.Add(adapterRealWorld);

                return adapterParent;
            }
        }

        public class BridgePatternsFactory : AbstractPatternsFactory
        {
            protected override PatternDetails CreatePatternDetails()
            {
                var bridgeParent = new PatternDetails
                {
                    Name = "Bridge",
                    Header = "Bridge",
                    Detailes = "Separates an object’s interface from its implementation - " +
                               "Decouple an abstraction from its implementation so that the two can vary independently.",
                    ImageUrl ="",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/bridge-design-pattern"),
                }
                };

                var bridgeStructural = new PatternDetails
                {
                    Name = "BridgeStructural",
                    Header = "Bridge Structural",
                    IsGofPattern = true,
                    Method = MethodService.BridgeStructural,
                    Detailes ="This structural code demonstrates the Bridge pattern which separates (decouples) the interface from its implementation."
                    +" The implementation can evolve without changing clients which use the abstraction of the object.",
                    ImageUrl ="",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/bridge-design-pattern#str"),
                }
                };


                var bridgeRealWorld = new PatternDetails
                {
                    Name = "BridgeRealWorld",
                    Header = "Bridge Real World",
                    IsGofPattern = true,
                    Method = MethodService.BridgeRealWorld,
                    Detailes = "This real-world code demonstrates the Bridge pattern in which a BusinessObject abstraction is decoupled from the implementation in DataObject."
                    +" The DataObject implementations can evolve dynamically without changing any clients.",
                    ImageUrl ="",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/bridge-design-pattern#rea"),
                }
                };

                bridgeParent.Patterns.Add(bridgeStructural);
                bridgeParent.Patterns.Add(bridgeRealWorld);

                return bridgeParent;
            }
        }

        public class CompositePatternsFactory : AbstractPatternsFactory
        {
            protected override PatternDetails CreatePatternDetails()
            {
                var compositeParent = new PatternDetails
                {
                    Name = "Composite",
                    Header = "Composite",
                    Detailes = "A tree structure of simple and composite objects - " +
                               "Compose objects into tree structures to represent part-whole hierarchies."
                               +" Composite lets clients treat individual objects and compositions of objects uniformly.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Composite-design-pattern"),
                }
                };

                var compositeStructural = new PatternDetails
                {
                    Name = "CompositeStructural",
                    Header = "Composite Structural",
                    IsGofPattern = true,
                    Method = MethodService.CompositeStructural,
                    Detailes = "This structural code demonstrates the Composite pattern which allows the creation "
                    +"of a tree structure in which individual nodes are accessed uniformly whether they are leaf nodes or branch (composite) nodes.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Composite-design-pattern#str"),
                }
                };


                var compositeRealWorld = new PatternDetails
                {
                    Name = "CompositeRealWorld",
                    Header = "Composite Real World",
                    IsGofPattern = true,
                    Method = MethodService.CompositeRealWorld,
                    Detailes = "This real-world code demonstrates the Composite pattern used in"
                    +" building a graphical tree structure made up of primitive nodes (lines, circles, etc) and composite nodes (groups of drawing elements that make up more complex elements).",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Composite-design-pattern#rea"),
                }
                };

                compositeParent.Patterns.Add(compositeStructural);
                compositeParent.Patterns.Add(compositeRealWorld);

                return compositeParent;
            }
        }

        public class DecoratorePatternsFactory : AbstractPatternsFactory
        {
            protected override PatternDetails CreatePatternDetails()
            {
                var decoratorParent = new PatternDetails
                {
                    Name = "Decorator",
                    Header = "Decorator",
                    Detailes = "Add responsibilities to objects dynamically - " +
                               "Attach additional responsibilities to an object dynamically. "
                               +"Decorators provide a flexible alternative to subclassing for extending functionality.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Decorator-design-pattern"),
                }
                };

                var decoratorStructural = new PatternDetails
                {
                    Name = "DecoratorStructural",
                    Header = "Decorator Structural",
                    IsGofPattern = true,
                    Method = MethodService.DecoratorStructural,
                    Detailes = "This structural code demonstrates the Decorator pattern which dynamically adds"
                    +" extra functionality to an existing object.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Decorator-design-pattern#str"),
                }
                };


                var decoratorRealWorld = new PatternDetails
                {
                    Name = "DecoratorRealWorld",
                    Header = "Decorator Real World",
                    IsGofPattern = true,
                    Method = MethodService.DecoratorRealWorld,
                    Detailes = "This real-world code demonstrates the Decorator pattern in which 'borrowable' "
                    +"functionality is added to existing library items (books and videos).",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Decorator-design-pattern#rea"),
                }
                };

                decoratorParent.Patterns.Add(decoratorStructural);
                decoratorParent.Patterns.Add(decoratorRealWorld);

                return decoratorParent;
            }
        }
    }
}