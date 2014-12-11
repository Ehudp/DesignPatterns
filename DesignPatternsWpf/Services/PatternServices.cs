using DesignPatterns.Utilities;
using DesignPatternsWpf.Model;
using DesignPatternsWpf.TreeFactory;
using DesignPatternsWpf.TreeFactory.Factories;
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
         
        public static List<PatternDetails> GetPatternDetailsList()
        {
            List<PatternDetails> patterns;
            patterns = new List<PatternDetails>();
            patterns.Add(GetCreationalPatternsDetails());
            return patterns;
        }

        public static PatternDetails GetPatternsFromFactory<T>() where T : AbstractPatternsFactory
        {

            var factory = Activator.CreateInstance<T>();
            return factory.GetPatternDetails();

        }

        public static PatternDetails GetPatternsFromFactory<T>(this AbstractPatternsFactory factory) where T : AbstractPatternsFactory
        {
            return GetPatternsFromFactory<T>();
        }


        #region Creational Patterns

        public static PatternDetails GetCreationalPatternsDetails()
        {
            var creationalPatterns = new CreationalPatternsFactory();

            return creationalPatterns.GetPatternDetails();
        }

        private static PatternDetails AbstractFactoryPatternsDetails()
        {
            var abstractFactoryPatterns = new AbstractFactoryPatternsFactory();

            return abstractFactoryPatterns.GetPatternDetails();
        }

        private static PatternDetails BuilderPatternsDetails()
        {
            var builderPatterns = new BuilderPatternsFactory();

            return builderPatterns.GetPatternDetails();

        }

        private static PatternDetails PrototypePatternsDetails()
        {
            var prototypePatterns = new PrototypePatternsFactory();

            return prototypePatterns.GetPatternDetails();

        }

        private static PatternDetails SingletonPatternsDetails()
        {

            var singletonPatterns = new SingletonPatternsFactory();

            return singletonPatterns.GetPatternDetails();

        }

        #endregion

        #region Structural Patterns

        public static PatternDetails GetStructuralPatternsDetails()
        {
            var structuralPatterns = new StructuralPatternsFactory();

            return structuralPatterns.GetPatternDetails();
        }

        #endregion

        #region Behavioral Patterns



        #endregion
    }
}
