namespace DesignPatterns.StructuralPatterns.Composite.RealWorld
{
    internal abstract class DrawingElement
    {
        protected string _name;
        // Constructor
        public DrawingElement(string name)
        {
            _name = name;
        }

        public abstract void Add(DrawingElement d);
        public abstract void Remove(DrawingElement d);
        public abstract void Display(int indent);
    }
}