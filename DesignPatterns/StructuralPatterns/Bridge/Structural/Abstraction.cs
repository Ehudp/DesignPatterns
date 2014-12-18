namespace DesignPatterns.StructuralPatterns.Bridge.Structural
{
    internal class Abstraction
    {
        protected Implementor implementor;
        // Property
        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}