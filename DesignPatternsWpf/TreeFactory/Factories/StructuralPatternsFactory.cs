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
    }
}