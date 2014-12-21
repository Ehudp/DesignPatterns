using Logger;

namespace DesignPatterns.StructuralPatterns.Decorator.RealWorld
{
    internal class Book : LibraryItem
    {
        private readonly string _author;
        private readonly string _title;
        // Constructor
        public Book(string author, string title, int numCopies)
        {
            _author = author;
            _title = title;
            NumCopies = numCopies;
        }

        public override void Display()
        {
            Log.WriteLine("\nBook ------ ");
            Log.WriteLine(" Author: {0}", _author);
            Log.WriteLine(" Title: {0}", _title);
            Log.WriteLine(" # Copies: {0}", NumCopies);
        }
    }
}