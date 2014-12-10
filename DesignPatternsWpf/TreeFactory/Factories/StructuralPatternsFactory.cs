using DesignPatternsWpf.Model;

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

            // structuralDetails.Patterns.Add(new AbstractFactoryPatternsFactory().GetPatternDetails());

            return structuralDetails;
        }
    }
}