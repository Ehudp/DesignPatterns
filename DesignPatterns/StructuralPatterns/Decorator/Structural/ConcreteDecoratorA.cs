using Logger;

namespace DesignPatterns.StructuralPatterns.Decorator.Structural
{
    internal class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Log.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }
}