using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsWpf.Model;
using DesignPatternsWpf.Services;
using DesignPatternsWpf.TreeFactory.Factories;

namespace DesignPatternsWpf.TreeFactory
{
    public class TreePatterns
    {
        //not recommend pattern
        //private static volatile TreePatterns instance;
        //private static object syncRoot = new Object();

        //private TreePatterns() { }

        //public static TreePatterns Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            lock (syncRoot)
        //            {
        //                if (instance == null)
        //                    instance = new TreePatterns();
        //            }
        //        }

        //        return instance;
        //    }
        //}
        private static readonly Lazy<TreePatterns> lazy =
        new Lazy<TreePatterns>(() => new TreePatterns());

        public static TreePatterns Instance { get { return lazy.Value; } }

        private TreePatterns()
        {
            
        }

        public List<PatternDetails> GetPatterns()
        {
            var patterns = new List<PatternDetails>
           {
               PatternServices.GetCreationalPatternsDetails(),
               GetPatternsFromFactory<StructuralPatternsFactory>(),
               GetPatternsFromFactory<BehavioralPatternsFactory>()
           };

            return patterns;
        }

        private  PatternDetails GetPatternsFromFactory<T>() where T : AbstractPatternsFactory
        {
            return PatternServices.GetPatternsFromFactory<T>();          

        }
    }
}
