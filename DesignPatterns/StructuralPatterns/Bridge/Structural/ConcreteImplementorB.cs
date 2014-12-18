using Logger;

namespace DesignPatterns.StructuralPatterns.Bridge.Structural
{
    internal class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Log.WriteLine("ConcreteImplementorB Operation");
        }
    }
}