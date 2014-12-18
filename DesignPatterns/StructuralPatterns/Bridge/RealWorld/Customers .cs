using Logger;

namespace DesignPatterns.StructuralPatterns.Bridge.RealWorld
{
    internal class Customers : CustomersBase
    {
        // Constructor
        public Customers(string group)
            : base(group)
        {
        }

        public override void ShowAll()
        {
            // Add separator lines
            Log.AddSeparator();
            Log.WriteLine("------------------------");
            base.ShowAll();
            Log.WriteLine("------------------------");
        }
    }
}