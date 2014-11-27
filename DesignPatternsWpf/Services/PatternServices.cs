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

        public static IList<PatternDetails> GetCreationalPatternsTree()
        {
            List<PatternDetails> creationalPatternsTree = new List<PatternDetails>();


            List<PatternDetails> abstractFactoryTree = new List<PatternDetails>();

            PatternDetails abstractFactoryParent = new PatternDetails
            {
                Name = "AbstractFactory",
           

            };

            PatternDetails abstractFactoryRealWorld = new PatternDetails
            {
                Name = "AbstractFactoryRealWorld",
             

            };

            PatternDetails abstractFactoryStructural = new PatternDetails
            {
                Name = "AbstractFactoryStructural",
              

            };

            return abstractFactoryTree;
        }
    }
}
