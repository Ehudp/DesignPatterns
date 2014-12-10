using DesignPatternsWpf.Model;

namespace DesignPatternsWpf.TreeFactory.Factories
{
    public abstract class AbstractPatternsFactory
    {
        protected PatternDetails PatternDetails;
        protected abstract PatternDetails CreatePatternDetails();

        public PatternDetails GetPatternDetails()
        {
            return PatternDetails ?? (PatternDetails = CreatePatternDetails());
        }
    }
}