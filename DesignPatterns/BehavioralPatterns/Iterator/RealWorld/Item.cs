namespace DesignPatterns.BehavioralPatterns.Iterator.RealWorld
{
    internal class Item
    {
        // Constructor
        public Item(string name)
        {
            Name = name;
        }

        // Gets name
        public string Name { get; private set; }
    }
}