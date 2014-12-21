using Logger;

namespace DesignPatterns.StructuralPatterns.Decorator.Structural
{
    internal class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Log.WriteLine("ConcreteDecoratorB.Operation()");
        }

        private void AddedBehavior()
        {
        }
    }
}