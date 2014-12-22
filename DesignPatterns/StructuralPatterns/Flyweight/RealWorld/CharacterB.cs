using Logger;

namespace DesignPatterns.StructuralPatterns.Flyweight.RealWorld
{
    /// <summary>
    ///     A 'ConcreteFlyweight' class
    /// </summary>
    internal class CharacterB : Character
    {
        // Constructor
        public CharacterB()
        {
            symbol = 'B';
            height = 100;
            width = 140;
            ascent = 72;
            descent = 0;
        }

        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Log.WriteLine(symbol +" (pointsize " + this.pointSize + ")");
        }
    }
}