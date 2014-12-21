using System;
using System.Collections.Generic;
using Logger;

namespace DesignPatterns.StructuralPatterns.Composite.RealWorld
{
    internal class CompositeElement : DrawingElement
    {
        private readonly List<DrawingElement> elements =new List<DrawingElement>();

        // Constructor
        public CompositeElement(string name)
            : base(name)
        {
        }

        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }

        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }

        public override void Display(int indent)
        {
            Log.WriteLine(new String('-', indent) + "+ " + _name);

            // Display each child element on this node
            foreach (var d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
}