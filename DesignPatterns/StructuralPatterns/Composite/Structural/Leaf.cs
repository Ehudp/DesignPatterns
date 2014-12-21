using System;
using Logger;

namespace DesignPatterns.StructuralPatterns.Composite.Structural
{
    internal class Leaf : Component
    {
        // Constructor
        public Leaf(string name)
            : base(name)
        {
        }

        public override void Add(Component c)
        {
            Log.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            Log.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Log.WriteLine(new String('-', depth) + name);
        }
    }
}