namespace DesignPatterns.CreationalPatterns.Builder.Structural
{
    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
