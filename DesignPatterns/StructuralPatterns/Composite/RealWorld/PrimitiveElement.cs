using System;
using Logger;

namespace DesignPatterns.StructuralPatterns.Composite.RealWorld
{
    internal class PrimitiveElement : DrawingElement
    {
        // Constructor
        public PrimitiveElement(string name)
            : base(name)
        {
        }

        public override void Add(DrawingElement c)
        {
            Log.WriteLine("Cannot add to a PrimitiveElement");
        }

        public override void Remove(DrawingElement c)
        {
            Log.WriteLine("Cannot remove from a PrimitiveElement");
        }

        public override void Display(int indent)
        {
            Log.WriteLine(new String('-', indent) + " " + _name);
        }
    }
}