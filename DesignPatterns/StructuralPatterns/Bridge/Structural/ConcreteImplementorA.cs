using Logger;

namespace DesignPatterns.StructuralPatterns.Bridge.Structural
{
    internal class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Log.WriteLine("ConcreteImplementorA Operation");
        }
    }
}