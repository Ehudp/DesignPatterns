namespace DesignPatterns.CreationalPatterns.Builder.Structural
{
    class Director
    {
        public void Construct(CreationalPatterns.Builder.Structural.Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
