namespace DesignPatterns.CreationalPatterns.Builder.Structural
{
   abstract  class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }
}
