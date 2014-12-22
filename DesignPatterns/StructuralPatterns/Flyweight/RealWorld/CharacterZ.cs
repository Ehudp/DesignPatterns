using Logger;

namespace DesignPatterns.StructuralPatterns.Flyweight.RealWorld
{
    /// <summary>
    ///     A 'ConcreteFlyweight' class
    /// </summary>
    internal class CharacterZ : Character
    {
        // Constructor
        public CharacterZ()
        {
            symbol = 'Z';
            height = 100;
            width = 100;
            ascent = 68;
            descent = 0;
        }

        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Log.WriteLine(symbol +" (pointsize " + this.pointSize + ")");
        }
    }
}