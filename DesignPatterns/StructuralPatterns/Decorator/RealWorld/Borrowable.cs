using System.Collections.Generic;
using Logger;

namespace DesignPatterns.StructuralPatterns.Decorator.RealWorld
{
    internal class Borrowable : Decorator
    {
        protected List<string> borrowers = new List<string>();
        // Constructor
        public Borrowable(LibraryItem libraryItem)
            : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (var borrower in borrowers)
            {
                Log.WriteLine(" borrower: " + borrower);
            }
        }
    }
}