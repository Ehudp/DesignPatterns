using DesignPatterns.Utilities;
using DesignPatternsWpf.Model;
using DesignPatternsWpf.TreeFactory;
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

        private static PatternDetails GetCreationalPatternsDetails()
        {
            var creationalPatterns = new CreationalPatternsFactorry();

            return creationalPatterns.GetPatternDetails();
        }

        private static PatternDetails AbstractFactoryPatternsDetails()
        {
            var abstractFactoryPatterns = new AbstractFactoryPatternsFactorry();

            return abstractFactoryPatterns.GetPatternDetails();
        }

        private static PatternDetails BuilderPatternsDetails()
        {
            var builderPatterns = new BuilderPatternsFactorry();

            return builderPatterns.GetPatternDetails();

        }

        private static PatternDetails PrototypePatternsDetails()
        {
            var prototypePatterns = new PrototypePatternsFactorry();

            return prototypePatterns.GetPatternDetails();

        }

        private static PatternDetails SingletonPatternsDetails()
        {

            var singletonPatterns = new SingletonPatternsFactorry();

            return singletonPatterns.GetPatternDetails();

        }
    }
}
