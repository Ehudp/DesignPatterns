namespace DesignPatterns.BehavioralPatterns.Iterator.Structural
{
    /// <summary>
    /// The 'Iterator' abstract class
    /// </summary>
    abstract class StructIterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
}