using Logger;

namespace DesignPatterns.StructuralPatterns.Flyweight.Structural
{
    /// <summary>
    /// The 'ConcreteFlyweight' class
    /// </summary>
    class ConcreteFlyweight : Structural.Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Log.WriteLine("ConcreteFlyweight: " + extrinsicstate);
        }
    }
}