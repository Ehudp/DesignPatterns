using Logger;

namespace DesignPatterns.BehavioralPatterns.Template_Method.Structural
{
    /// <summary>
    ///     A 'ConcreteClass' class
    /// </summary>
    internal class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Log.WriteLine("ConcreteClassB.PrimitiveOperation1()");
        }

        public override void PrimitiveOperation2()
        {
            Log.WriteLine("ConcreteClassB.PrimitiveOperation2()");
        }
    }
}