namespace DesignPatterns.BehavioralPatterns.Iterator.Structural
{
    internal abstract class Aggregate
    {
        public abstract StructIterator CreateIterator();
    }
}