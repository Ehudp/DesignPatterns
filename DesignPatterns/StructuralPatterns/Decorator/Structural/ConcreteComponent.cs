using Logger;

namespace DesignPatterns.StructuralPatterns.Decorator.Structural
{
    internal class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Log.WriteLine("ConcreteComponent.Operation()");
        }
    }
}