namespace DesignPatterns.StructuralPatterns.Decorator.RealWorld
{
    internal abstract class LibraryItem
    {
        // Property
        public int NumCopies { get; set; }
        public abstract void Display();
    }
}