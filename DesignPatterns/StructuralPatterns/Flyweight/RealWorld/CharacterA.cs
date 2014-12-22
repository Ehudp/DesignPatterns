using Logger;

namespace DesignPatterns.StructuralPatterns.Flyweight.RealWorld
{
    /// <summary>
    ///     A 'ConcreteFlyweight' class
    /// </summary>
    internal class CharacterA : Character
    {
        // Constructor
        public CharacterA()
        {
            symbol = 'A';
            height = 100;
            width = 120;
            ascent = 70;
            descent = 0;
        }

        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Log.WriteLine(symbol +" (pointsize " + this.pointSize + ")");
        }
    }
}