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



            creationaParent.Patterns.Add(GetAbstractFactoryTree());


            return creationaParent;

        }

        private static PatternDetails GetAbstractFactoryTree()
        {

           
            PatternDetails abstractFactoryParent = new PatternDetails
            {
                Name = "AbstractFactory",
                Header = "Abstract Factory",
                IsGofPattern = true

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
                ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/AbstractFactoryUMl.gif"
            };

            PatternDetails abstractFactoryStructural = new PatternDetails
            {
                Name = "AbstractFactoryStructural",
                Header = "Abstract Factory Structural",
                IsGofPattern = false,
                Method = MethodService.AbstractFactoryStructural,
                Detailes = "This structural code demonstrates the Abstract Factory pattern creating parallel hierarchies of objects."
                +" Object creation has been abstracted and there is no need for hard-coded class names in the client code.",
                Url="http://www.dofactory.com/net/abstract-factory-design-pattern#str",
                ImageUrl = @"pack://application:,,,/DesignPatterns;component/Images/AbstractFactoryUMl.gif"

            };

            abstractFactoryParent.Patterns.Add(abstractFactoryRealWorld);
            abstractFactoryParent.Patterns.Add(abstractFactoryStructural);

            return abstractFactoryParent;
        }
    }
}
