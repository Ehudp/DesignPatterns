using Logger;

namespace DesignPatterns.StructuralPatterns.Flyweight.Structural
{
    /// <summary>
    /// The 'UnsharedConcreteFlyweight' class
    /// </summary>
    class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Log.WriteLine("UnsharedConcreteFlyweight: " +
                          extrinsicstate);
        }
    }
}