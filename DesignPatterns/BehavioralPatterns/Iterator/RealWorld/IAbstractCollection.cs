namespace DesignPatterns.BehavioralPatterns.Iterator.RealWorld
{
    /// <summary>
    /// The 'Aggregate' interface
    /// </summary>
    interface IAbstractCollection
    {
        RealIterator CreateIterator();
    }
}