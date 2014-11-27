using DesignPatterns.Utilities;
using DesignPatternsWpf.Model;
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
                IsGofPattern = true
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
                Method = MethodService.AbstractFactoryRealWorld
            };

            PatternDetails abstractFactoryStructural = new PatternDetails
            {
                Name = "AbstractFactoryStructural",
                Header = "Abstract Factory Structural",
                IsGofPattern = true,
                Method = MethodService.AbstractFactoryStructural

            };

            abstractFactoryParent.Patterns.Add(abstractFactoryRealWorld);
            abstractFactoryParent.Patterns.Add(abstractFactoryStructural);

            return abstractFactoryParent;
        }
    }
}
