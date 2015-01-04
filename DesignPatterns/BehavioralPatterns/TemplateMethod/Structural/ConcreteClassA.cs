using Logger;

namespace DesignPatterns.BehavioralPatterns.TemplateMethod.Structural
{
    /// <summary>
    ///     A 'ConcreteClass' class
    /// </summary>
    internal class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Log.WriteLine("ConcreteClassA.PrimitiveOperation1()");
        }

        public override void PrimitiveOperation2()
        {
            Log.WriteLine("ConcreteClassA.PrimitiveOperation2()");
        }
    }
}